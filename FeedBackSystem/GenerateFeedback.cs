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


            MySql sql = new MySql();
            sql.OpenConnection();

            List<Applicant> applicants = sql.GetApplicants();

            foreach(Applicant app in applicants)
            {
                ApplicantList.Items.Add(app);
            }

            ApplicantList.ValueMember = "Name";

            sql.CloseConnection();

            
        }

        private void AddSectionBtn_Click(object sender, EventArgs e)
        {
            SectionTable.Controls.Clear();

            RowStyle style = new RowStyle { SizeType = SizeType.AutoSize };

            ContentTable.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            SectionTable.RowStyles.Add(style);


            using (SelectSection form = new SelectSection())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    foreach (Section s in form._sectionSelected)
                    {
                        SectionTable.Controls.Add(new Label { Text = s.Title, Anchor = AnchorStyles.Left, TextAlign = ContentAlignment.MiddleLeft }, 0, row);
                        ComboBox codes = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Anchor = AnchorStyles.Right };

                        foreach (string code in s.Codes)
                        {
                            codes.Items.Add(code);
                        }

                        SectionTable.Controls.Add(codes, 1, row);
                        SectionTable.Controls.Add(new RichTextBox { Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top }, 0, row + 1);
                        row++;
                        row++;
                    }

                    _currentFeed.Sections.Clear();
                    _currentFeed.Sections.AddRange(form._sectionSelected);

                    AddSectionBtn.Text = "Change Section";

                }
            }

                //SectionPlacement usercontrol = new SectionPlacement();

                //SectionTable.Controls.Add(usercontrol, 0, SectionTable.RowCount - 1);
                //SectionTable.ScrollControlIntoView(usercontrol);

                //SectionTable.Controls.Add(new Label {Text = "Title", Anchor = AnchorStyles.Left, TextAlign = ContentAlignment.MiddleLeft},0,row);
                //SectionTable.Controls.Add(new ComboBox() {DropDownStyle = ComboBoxStyle.DropDownList,Anchor = AnchorStyles.Right},1,row);
                //SectionTable.Controls.Add(new RichTextBox {Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top},0,row+1);

                

        }

        private void ApplicantList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ApplicantList.SelectedIndex != -1)
            {
                Applicant app = (Applicant)ApplicantList.SelectedItem;

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
            }
        }

        private void AddHeaderBtn_Click(object sender, EventArgs e)
        {
            

            using (SelectHeader form = new SelectHeader())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {

                    Header selectedHeader = form.Header;

                    HeaderPlacement place = new HeaderPlacement();

                    foreach (HeaderItem item in selectedHeader.HeaderItems)
                    {
                        place.AddItem(item);
                    }

                    ContentTable.Controls.Remove(AddHeaderBtn);
                    ContentTable.Controls.Add(place, 0, 0);
                    _currentFeed.Header = selectedHeader;
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
                    HeaderPlacement place = new HeaderPlacement();

                    ContentTable.Controls.Remove(ContentTable.GetControlFromPosition(0, 0));

                    foreach (HeaderItem item in form.Header.HeaderItems)
                    {
                        place.AddItem(item);
                    }

                    _currentFeed.Header = form.Header;
                    ContentTable.Controls.Add(place, 0, 0);
                }
            }
                
        }

        private void SaveFeedbackBtn_Click(object sender, EventArgs e)
        {
            Applicant app = (Applicant)ApplicantList.SelectedItem;
            _currentFeed.ApplicantId = app.Id;
            _currentFeed.ReviewerId = Reviewer.Id.ToString();
            MessageBox.Show(_currentFeed.Header.Title);
        }
    }
}
