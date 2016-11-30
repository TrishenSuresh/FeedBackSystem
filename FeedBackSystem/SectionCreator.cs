using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class SectionCreator : Form
    {
        private bool _update = false;
        private Section _section;

        public SectionCreator()
        {
            InitializeComponent();
            _section = new Section();
        }

        public SectionCreator(string id)
        {

            _update = true;

            InitializeComponent();
            MySql sql = new MySql();
            sql.OpenConnection();

            _section = sql.GetSection(id);

            SectionTitleText.Text = _section.Title;
            SectionDescText.Text = _section.Desc;

            foreach (string c in _section.Codes)
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

                _section.Title = SectionTitleText.Text;
                _section.Desc = SectionDescText.Text;
                _section.Codes.Clear();
                _section.Codes.AddRange(codes);

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
                    if (sql.UpdateSection(_section))
                    {
                        MessageBox.Show("Section successfully saved");
                        DialogResult = DialogResult.OK;
                        Close();
                    }

                }
            }

        } //end save button
    }
}
