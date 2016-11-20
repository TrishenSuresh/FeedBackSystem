using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

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
            AddHeaderBtn.Enabled = false;

            ContentTable.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);

            MySql sql = new MySql();
            sql.OpenConnection();


            /* they shouldnt be able to see this before they select the position
            List<Applicant> applicants = sql.GetApplicants();

            foreach (Applicant app in applicants)
            {
                ApplicantList.Items.Add(app);
            }*/

            ApplicantList.ValueMember = "Name";

            List<Position> positions = sql.GetPositions();

            foreach (Position p in positions)
            {
                PositionList.Items.Add(p);
            }

            PositionList.ValueMember = "_positionName";


            sql.CloseConnection();


        }

        private void AddSectionBtn_Click(object sender, EventArgs e)
        {
            SectionTable.Controls.Clear();

            RowStyle style = new RowStyle {SizeType = SizeType.AutoSize};

            SectionTable.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            HeaderControls.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);

            SectionTable.RowStyles.Add(style);


            using (SelectSection form = new SelectSection())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    foreach (Section s in form._sectionSelected)
                    {


                      

                        SectionTable.Controls.Add(new CheckBox {Anchor = AnchorStyles.Left, Name = "checker"+s.SectionId, AutoSize = true},0,row);

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
                            Name = "codes" + s.SectionId
                        };

                        foreach (string code in s.Codes)
                        {
                            codes.Items.Add(code);
                        }

                        SectionTable.Controls.Add(codes, 2, row);
                        SectionTable.Controls.Add(
                            new RichTextBox
                            {
                                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                                Name = "comment" + s.SectionId
                            }, 1, row + 1);
                        row++;
                        row++;
                    }

                    if (_currentFeed.Sections != null)
                        _currentFeed.Sections.Clear();

                    _currentFeed.Sections.AddRange(form._sectionSelected);

                    AddSectionBtn.Text = "Change Section";

                }
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

                if(_currentFeed.Header != null)
                {
                    UpdateHeaderTab();
                }
            }
        }

        private void UpdateHeaderTab()
        {
            HeaderPlacement place = new HeaderPlacement();

            ContentTable.Controls.Remove(ContentTable.GetControlFromPosition(0, 0));

            foreach (HeaderItem item in _currentFeed.Header.HeaderItems)
            {
                if(item.InputType.Equals("Query"))
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
                place.AddItem(item);
            }
            
            ContentTable.Controls.Add(place, 0, 0);
        }

        private void AddHeaderBtn_Click(object sender, EventArgs e)
        {
            using (SelectHeader form = new SelectHeader())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Header selectedHeader = form.Header;
                    _currentFeed.Header = selectedHeader;

                    UpdateHeaderTab();
                    
                    ChangeHeader.Visible = true;
                }
            }
        }

        private void ChangeHeader_Click(object sender, EventArgs e)
        {
            using (SelectHeader form = new SelectHeader())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _currentFeed.Header = form.Header;
                    UpdateHeaderTab();
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
                            item.ValueChosen = ((TextBox)control).Text;
                            break;
                        case "ComboBox":
                            item.ValueChosen = ((ComboBox)control).SelectedItem.ToString();
                            break;
                        case "DateTimePicker":
                            item.ValueChosen = ((DateTimePicker)control).Value.ToString("dd/MM/yyyy");
                            break;
                        case "Label":
                            item.ValueChosen = ((Label)control).Text;
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
            if (sql.SaveFeedback(_currentFeed))
                MessageBox.Show("Sucessfully inserted into the database");
            else
                return;

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

                    if (sql.SaveTemplate(_currentFeed, save.Title, save.Desc))
                    {
                        MessageBox.Show("Template successfully saved");
                    }

                    sql.CloseConnection();
                }
            }
        }
    }
}
