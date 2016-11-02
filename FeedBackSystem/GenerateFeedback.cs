using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace FeedBackSystem
{
    public partial class GenerateFeedback : UserControl
    {
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
            RowStyle style = new RowStyle { SizeType = SizeType.AutoSize };

            ContentTable.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            SectionTable.RowStyles.Add(style);

            Section usercontrol = new Section();

            SectionTable.Controls.Add(usercontrol, 0, SectionTable.RowCount - 1);
            SectionTable.ScrollControlIntoView(usercontrol);

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
    }
}
