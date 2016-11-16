using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class SectionCreator : Form
    {
        public SectionCreator()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CodeBox.Text))
            {
                MessageBox.Show(@"Codes cannot be empty.");
            }
            else
            {
                using (SaveBox save = new SaveBox())
                {
                    var result = save.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        MySql sql = new MySql();
                        sql.OpenConnection();

                        List<string> codes = new List<string>(CodeBox.Lines);
                        codes.RemoveAll(item => item.Length == 0);

                        if (sql.SaveSection(new Section(save.Title, save.Desc, codes)))
                        {
                            MessageBox.Show("Section succesfully saved");
                            sql.CloseConnection();
                            this.Close();
                        }
                        

                    }
                }
            }

        }
    }
}
