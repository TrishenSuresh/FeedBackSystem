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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            new ToolTip().SetToolTip(UsernameText, "FirstName.LastName. eg: bob.smith");
            AcceptButton = loginBtn;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MySql sql = new MySql();


            if (sql.VerifyPassword(username.Text, password.Text))
            {
                Reviewer.ReviewerName = username.Text.Replace(".", " ");
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid Username/Password", @"An Error has Occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
