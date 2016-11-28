using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class SectionCreator : Form
    {
        private bool _update = false;

        public SectionCreator()
        {
            InitializeComponent();
        }

        public SectionCreator(string id)
        {

            _update = true;

            InitializeComponent();
            MySql sql = new MySql();
            sql.OpenConnection();

            Section sec = sql.GetSection(id);

            SectionTitleText.Text = sec.Title;
            SectionDescText.Text = sec.Desc;

            foreach (string c in sec.Codes)
            {
                CodeBox.AppendText(c+Environment.NewLine);
            }


            sql.CloseConnection();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CodeBox.Text) || String.IsNullOrEmpty(SectionTitleText.Text))
            {
                MessageBox.Show(@"Title or Codes cannot be empty.");
            }
            else
            {
                MySql sql = new MySql();
                sql.OpenConnection();

                List<string> codes = new List<string>(CodeBox.Lines);
                codes.RemoveAll(item => item.Length == 0);

                if (!_update)
                {
                    if (!sql.SaveSection(new Section(SectionTitleText.Text, SectionDescText.Text, codes))) return;
                    MessageBox.Show("Section succesfully saved");
                    sql.CloseConnection();

                    //after the saving is done, go back to the home page showing the list of available sections
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    //This part updates the section
                }
            }

        } //end save button
    }
}
