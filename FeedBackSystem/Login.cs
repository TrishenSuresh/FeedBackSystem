using System;
using System.Drawing;
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
           
            UsernameHelp.Image = new Icon(SystemIcons.Question,32,32).ToBitmap();

            new ToolTip().SetToolTip(UsernameHelp,"Combination of First name and last name seperated by a period '.'");
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MySql sql = new MySql();
            sql.OpenConnection();

            if (sql.VerifyPassword(username.Text, password.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(@"Invalid Username/Password", @"An Error has Occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sql.CloseConnection();
        }

        private void UsernameHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your username is a combination of your first name and last name, seperated by a period(.)\neg Bob.Smith", @"What's my username?");
        }
    }
}
