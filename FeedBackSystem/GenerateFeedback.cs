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
            AddHeaderBtn.Enabled = false;

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

            ContentTable.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            SectionTable.RowStyles.Add(style);


            using (SelectSection form = new SelectSection())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    foreach (Section s in form._sectionSelected)
                    {
                        SectionTable.Controls.Add(
                            new Label
                            {
                                Text = s.Title,
                                Anchor = AnchorStyles.Left,
                                TextAlign = ContentAlignment.MiddleLeft
                            }, 0, row);
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

                        SectionTable.Controls.Add(codes, 1, row);
                        SectionTable.Controls.Add(
                            new RichTextBox
                            {
                                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                                Name = "comment" + s.SectionId
                            }, 0, row + 1);
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
                switch (item.Title)
                {
                    case "Applicant:":
                        item.ValueItem.Clear();
                        item.ValueItem.Add(_currentFeed.Applicant.Name);
                        break;
                    case "Job applied:":
                        item.ValueItem.Clear();
                        item.ValueItem.Add(_currentFeed.Position._positionName);
                        break;
                    case "Reviewer:":
                        item.ValueItem.Clear();
                        item.ValueItem.Add(Reviewer.Name);
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

            if (ApplicantList.SelectedIndex == -1)
            {
                MessageBox.Show("Select an applicant");
                return;
            }

            if (_currentFeed.Header == null)
            {
                MessageBox.Show("Please Complete the header before proceeding");
                return;
            }

            if (_currentFeed.Sections.Count <= 0)
            {
                MessageBox.Show("Please complete the sections before proceeding");
                return;
            }
            
            _currentFeed.ReviewerId = Reviewer.Id.ToString();

            foreach (Section s in _currentFeed.Sections)
            {
                RichTextBox text = (RichTextBox) Controls.Find("comment" + s.SectionId, true)[0];
                ComboBox codes = (ComboBox) Controls.Find("codes" + s.SectionId, true)[0];

                if (codes.SelectedIndex == -1)
                {
                    MessageBox.Show("Please complete the sections before proceeding");
                    return;
                }

                s.Comment = text.Text;
                s.CodeChosen = codes.SelectedItem.ToString();

                if (s.Comment.Length <= 0)
                {
                    MessageBox.Show("Please complete the sections before proceeding");
                    return;
                }
            }

            foreach (HeaderItem item in _currentFeed.Header.HeaderItems)
            {

                Control control = Controls.Find("header" + item.Id, true)[0];

                try
                {
                    switch (control.GetType().Name)
                    {
                        case "TextBox":
                            item.ValueChosen = ((TextBox) control).Text;
                            break;
                        case "ComboBox":
                            item.ValueChosen = ((ComboBox) control).SelectedItem.ToString();
                            break;
                        case "DateTimePicker":
                            item.ValueChosen = ((DateTimePicker) control).Value.ToString("dd/MM/yyyy");
                            break;
                        case "Label":
                            item.ValueChosen = ((Label) control).Text;
                            break;
                    }

                    if(item.ValueChosen.Length <= 0)
                        throw new NullReferenceException();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Please Complete the header before proceeding");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                
            }

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
    }
}
