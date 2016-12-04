using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace FeedBackSystem
{
    public partial class GenerateFeedback : UserControl
    {
        private int row = 0;
        Feedback _currentFeed = new Feedback();

        public GenerateFeedback()
        {
            InitializeComponent();

            SectionTable.VerticalScroll.Enabled = false;
            ContentTable.VerticalScroll.Enabled = true;
            SectionTable.HorizontalScroll.Enabled = false;
            //AddHeaderBtn.Enabled = false;
            AddHeaderBtn.Visible = false;
            AddSectionBtn.Visible = false;
            SetTemplateBtn.Enabled = false;
            SaveTemplateBtn.Enabled = false;

            ContentTable.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);

            MySql sql = new MySql();
            sql.OpenConnection();
            
            ApplicantList.ValueMember = "Name";

            List<Position> positions = sql.GetPositions();

            foreach (Position p in positions)
            {
                PositionList.Items.Add(p);
            }

            PositionList.ValueMember = "_positionName";
            
            sql.CloseConnection();
        }

        private void AddSectionBtn_Click(object sender, EventArgs e) { setSection(); }

        private void setSection()
        {
            _currentFeed.Sections.Clear();

            //using (SelectControl form = new SelectControl("Section"))
            //{
            //    var result = form.ShowDialog();

            //    if (result == DialogResult.OK)
            //    {
            //        MySql sql = new MySql();
            //        sql.OpenConnection();
            //        foreach (string id in form._ids)
            //        {
            //            _currentFeed.Sections.Add(sql.GetSection(id));
            //        }

            //        _currentFeed.Sections.Reverse();

            //        FillSection();
            //    } 
            //}

            Form window = new Form { Text = "Select Sections", ControlBox = false, FormBorderStyle = FormBorderStyle.FixedDialog, StartPosition = FormStartPosition.CenterParent};

            window.Size = new Size(1320, 330);

            window.Controls.Add(new SectionSelection {Name = "SectionSelection"});

            Button ok = new Button { Location = new Point(1200, 250), Text = "Ok" };
            ok.Click += (s, e) => { window.DialogResult = DialogResult.OK; window.Close(); };
            window.Controls.Add(ok);


            var result = window.ShowDialog();

            if (result == DialogResult.OK)
            {
                SectionSelection sectionSelection = (SectionSelection)window.Controls.Find("SectionSelection", true)[0];

                foreach (Section s in sectionSelection.SelectedSections)
                {
                    _currentFeed.Sections.Add(s);
                }

                FillSection();
            }
        }

        private void FillSection()
        {
            SectionTable.Controls.Clear();

            RowStyle style = new RowStyle { SizeType = SizeType.AutoSize };

            SectionTable.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            HeaderControls.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);

            SectionTable.RowStyles.Add(style);

            foreach (Section s in _currentFeed.Sections)
            {
                SectionTable.Controls.Add(new CheckBox { Anchor = AnchorStyles.Left, Name = "checker" + s.SectionId, AutoSize = true, Checked = (object.ReferenceEquals(s.IsChecked, null) ? false : s.IsChecked) }, 0, row);

                SectionTable.Controls.Add(
                    new Label
                    {
                        Text = s.Title,
                        Anchor = AnchorStyles.Left,
                        TextAlign = ContentAlignment.MiddleLeft
                    }, 1, row);

                ComboBox codes = new ComboBox
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Anchor = AnchorStyles.Right,
                    Name = "codes" + s.SectionId,
                    FlatStyle = FlatStyle.Flat
                    };

                foreach (string code in s.Codes)
                {
                    codes.Items.Add(code);
                }

                if(!object.ReferenceEquals(s.CodeChosen, null))
                {
                    codes.SelectedItem = (s.Codes.Find(x => x.Equals(s.CodeChosen)));
                }

                SectionTable.Controls.Add(codes, 2, row);
                RichTextBox comment = new RichTextBox
                { 
                    Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                    Name = "comment" + s.SectionId,
                    Text = (object.ReferenceEquals(s.Comment, null) ? null : s.Comment)
                };

                SectionTable.Controls.Add(comment, 1, row + 1);
                SectionTable.SetColumnSpan(comment,2);
                row++;
                row++;
            }
        }

        private void ApplicantList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ApplicantList.SelectedIndex != -1)
            {
                PDFDisplay.DocumentText = "<HTML><CENTER>Loading...</CENTER></HTML>";

                Applicant app = (Applicant) ApplicantList.SelectedItem;
                _currentFeed.Applicant = app;
                AddHeaderBtn.Enabled = true;

                if (app.Pdf != null)
                {
                    string tempFile = Path.GetTempFileName();
                    tempFile = Path.ChangeExtension(tempFile, "pdf");
                    File.WriteAllBytes(tempFile, app.Pdf);
                    PDFDisplay.Navigate(tempFile);
                }
                else
                {
                    PDFDisplay.DocumentText = "<HTML><CENTER>No PDF found</CENTER></HTML>";
                }
                
                MySql sql = new MySql();
                sql.OpenConnection();
                
                DataTable Dt = sql.GetDataSet("SELECT * FROM feedbacksystem.feedback WHERE feedback.PositionID = " + _currentFeed.Position._positionId + " AND feedback.AppID = " + _currentFeed.Applicant.Id);
                if(Dt != null && Dt.Rows.Count > 0)
                {
                    Feedback tmpFeedback = sql.GetFeedback(Dt.Rows[0]["FeedbackID"].ToString());
                    _currentFeed.FeedbackID = Dt.Rows[0]["FeedbackID"].ToString();
                    _currentFeed.Header = tmpFeedback.Header;
                    _currentFeed.Sections = tmpFeedback.Sections;
                    FillHeader();
                    FillSection();
                    sql.CloseConnection();

                    SaveFeedbackBtn.Text = "Update Feedback";

                    return;
                } else
                {
                    SaveFeedbackBtn.Text = "Save Feedback";
                    if (_currentFeed.Header != null)
                    {
                        _currentFeed.Header.HeaderItems.Clear();
                        //in order to reset the header items value for the cascading
                        _currentFeed.Header.HeaderItems = sql.GetHeaderItems(_currentFeed.Header.HeaderId);

                        FillHeader();
                    }

                    if(_currentFeed.Sections.Count > 0)
                    {
                        foreach(Section sec in _currentFeed.Sections)
                        {
                            sec.Comment = null;
                            sec.CodeChosen = null;
                            sec.IsChecked = false;
                        }
                        FillSection();
                    }
                }
                
                sql.CloseConnection();
                SetTemplateBtn.Enabled = true;
            }
        }

        private void FillHeader()
        {
            HeaderPlacement place = new HeaderPlacement();

            ContentTable.Controls.Remove(ContentTable.GetControlFromPosition(0, 0));

            foreach (HeaderItem item in _currentFeed.Header.HeaderItems)
            {
                if (item.InputType.Equals("Query"))
                {
                    switch (item.ValueItem[0])
                    {
                        case "<Applicant Name>":
                            item.ValueItem.Clear();
                            item.ValueItem.Add(_currentFeed.Applicant.Name);
                            break;
                        case "<Applied Position>":
                            item.ValueItem.Clear();
                            item.ValueItem.Add(_currentFeed.Position._positionName);
                            break;
                        case "<Reviewer Name>":
                            item.ValueItem.Clear();
                            item.ValueItem.Add(Reviewer.Name);
                            break;
                        case "<Application Type>":
                            item.ValueItem.Clear();
                            item.ValueItem.Add(_currentFeed.Applicant.ApplyType);
                            break;
                        case "<Applicant Email>":
                            item.ValueItem.Clear();
                            item.ValueItem.Add(_currentFeed.Applicant.Email);
                            break;
                        case "<Application Status>":
                            item.ValueItem.Clear();
                            item.ValueItem.Add(_currentFeed.Applicant.ApplyType);
                            break;
                        case "<Review Date>":
                            item.ValueItem.Clear();
                            item.ValueItem.Add(_currentFeed.Applicant.Date);
                            break;
                    }
                }
                place.AddItem(item);
            }
            
            ContentTable.Controls.Add(place, 0, 0);
        }

        private void AddHeaderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                setHeader();
            } catch (Exception ex)
            { return; }

        }
        private void setHeader()
        {
            using (SelectControl form = new SelectControl("Header"))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MySql sql = new MySql();
                    sql.OpenConnection();

                    _currentFeed.Header = sql.GetHeader(form._ids[0]);
                    _currentFeed.Header.HeaderItems = sql.GetHeaderItems(_currentFeed.Header.HeaderId);

                    FillHeader();

                    //ChangeHeader.Visible = true;

                    sql.CloseConnection();
                } else
                {
                    /*
                     * To prevent the continuation of the method calls to setSection in setTemplate 
                     * when the user did not select any header (direct close window)
                     */
                    throw new Exception();
                }
            }
                
        }

        private void SaveFeedbackBtn_Click(object sender, EventArgs e)
        {
            if (PositionList.SelectedIndex == -1)
            {
                MessageBox.Show("Select a position", "Missing attributes!");
                return;
            }

            if (ApplicantList.SelectedIndex == -1)
            {
                MessageBox.Show("Select an applicant", "Missing attributes!");
                return;
            }

            if (_currentFeed.Header == null)
            {
                MessageBox.Show("Please select the header before proceeding", "Missing component!");
                return;
            }

            if (_currentFeed.Sections.Count <= 0)
            {
                MessageBox.Show("Please select the sections before proceeding", "Missing component!");
                return;
            }
            
            _currentFeed.ReviewerId = Reviewer.Id.ToString();

            //check if there are null values in the header 
            foreach (HeaderItem item in _currentFeed.Header.HeaderItems)
            {

                Control control = Controls.Find("header" + item.Id, true)[0];

                try
                {
                    switch (control.GetType().Name)
                    {
                        case "TextBox":
                        case "Label":
                            item.ValueChosen = ((TextBox)control).Text;
                            break;
                        case "ComboBox":
                            item.ValueChosen = ((ComboBox)control).SelectedItem.ToString();
                            break;
                        case "DateTimePicker":
                            item.ValueChosen = ((DateTimePicker)control).Value.ToString("dd/MM/yyyy");
                            break;
                    }

                    if (item.ValueChosen.Length <= 0)
                        throw new NullReferenceException();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Please complete the header before proceeding", "Missing attributes!");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                    return;
                }
            }

            //check if there is null values in the sections
            foreach (Section s in _currentFeed.Sections)
            {
                RichTextBox text = (RichTextBox) Controls.Find("comment" + s.SectionId, true)[0];
                ComboBox codes = (ComboBox) Controls.Find("codes" + s.SectionId, true)[0];
                CheckBox checker = (CheckBox) Controls.Find("checker" + s.SectionId, true)[0];


                if (codes.SelectedIndex == -1)
                {
                    MessageBox.Show("Please complete the sections before proceeding -> Codes", "Missing attributes!");
                    return;
                }

                //Assign values to section object
                s.Comment = text.Text;
                s.CodeChosen = codes.SelectedItem.ToString();
                s.IsChecked = checker.Checked;

                if (s.Comment.Length <= 0)
                {
                    MessageBox.Show("Please complete the sections before proceeding -> Comment", "Missing attributes!");
                    return;
                }


            }
            
            //end of field checkers

            MySql sql = new MySql();
            sql.OpenConnection();
            if (String.IsNullOrEmpty(_currentFeed.FeedbackID))
            {
                if (sql.SaveFeedback(_currentFeed))
                    MessageBox.Show("Sucessfully inserted into the database"); 
            } else
            {
                if (sql.UpdateFeedback(_currentFeed))
                    MessageBox.Show("Sucessfully updated the feedback.");
            }

            sql.CloseConnection();

        }

        private void PositionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PositionList.SelectedIndex != -1)
            {
                MySql sql = new MySql();
                sql.OpenConnection();
                Position pos = (Position) PositionList.SelectedItem;
                _currentFeed.Position = pos;
                List<Applicant> app = sql.GetAppByPosition(pos._positionId);

                ApplicantList.Items.Clear();

                foreach (Applicant p in app)
                {
                    ApplicantList.Items.Add(p);
                }

                sql.CloseConnection();

                _currentFeed.Applicant = null;
                _currentFeed.Header = null;
                _currentFeed.Sections.Clear();
                ContentTable.Controls.Remove(ContentTable.GetControlFromPosition(0, 0));
                SectionTable.Controls.Clear();
                PDFDisplay.DocumentText = "";

                SaveFeedbackBtn.Text = "Save Feedback";
            }

        }

        private void SaveTemplateBtn_Click(object sender, EventArgs e)
        {
            using (SaveBox save = new SaveBox())
            {
                var result = save.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MySql sql = new MySql();

                    sql.OpenConnection();

                    if (sql.SaveTemplate(_currentFeed.Header,_currentFeed.Sections, save.Title, save.Desc))
                    {
                        MessageBox.Show("Template successfully saved");
                    }

                    sql.CloseConnection();
                }
            }
        }

        private void SetTemplateBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("[Yes] To load template.\n[No] To select header and sections separately."
                         , "Choose Loading Method", MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                if(result == DialogResult.Yes)
                {
                    ChangeHeader.Visible = false;
                    AddSectionBtn.Visible = false;
                    SaveTemplateBtn.Enabled = false;

                    using (SelectControl form = new SelectControl("Template"))
                    {
                        var selectResult = form.ShowDialog();

                        if (selectResult == DialogResult.OK)
                        {
                            MySql sql = new MySql();
                            sql.OpenConnection();

                            string sqlStatement = "select * from template where TemplateID = @id";
                            MySqlCommand cmd = new MySqlCommand(sqlStatement);
                            cmd.Parameters.AddWithValue("@id", form._ids[0]);
                            DataTable template = sql.GetDataSetCmd(cmd);

                            _currentFeed.Header = sql.GetHeader(template.Rows[0][1].ToString());
                            _currentFeed.Header.HeaderItems = sql.GetHeaderItems(_currentFeed.Header.HeaderId);

                            FillHeader();
                            
                            _currentFeed.Sections.Clear();
                            cmd.Parameters.Clear();

                            sqlStatement = "SELECT * FROM template_section WHERE TemplateID = @id";
                            cmd = new MySqlCommand(sqlStatement);
                            cmd.Parameters.AddWithValue("@id", form._ids[0]);
                            DataTable templateSections = sql.GetDataSetCmd(cmd);
                            
                            foreach (DataRow row in templateSections.Rows)
                            {
                                _currentFeed.Sections.Add(sql.GetSection(row["SectionID"].ToString()));
                            }
                            FillSection();
                            
                            sql.CloseConnection();
                            
                        }
                    }
                }
                else //Will default to select header and sections
                {
                    try
                    {
                        setHeader();
                        ChangeHeader.Visible = true;
                        setSection();
                        AddSectionBtn.Visible = true;
                        AddSectionBtn.Text = "Change Section";
                        SaveTemplateBtn.Enabled = true;
                    } catch (Exception ex)
                    {
                        return;
                    }
                }
            }
        }
    }
}
