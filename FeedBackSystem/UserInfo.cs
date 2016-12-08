using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FeedBackSystem
{
    public partial class UserInfo : Form
    {
        string id;

        public UserInfo()
        {
            InitializeComponent();
        }

        public UserInfo(string text)
        {
            InitializeComponent();
            this.Text = text;
        }

        public UserInfo(string id, string text)
        {
            InitializeComponent();
            this.Text = text;

            MySql sql = new MySql();
            sql.OpenConnection();

            string sqlStatement = "select * from reviewer where ReviewerID = @id";
            MySqlCommand cmd = new MySqlCommand(sqlStatement);
            cmd.Parameters.AddWithValue("@id", id);
            DataTable  user = sql.GetDataSetCmd(cmd);

            AddUserBtn.Text = "Save User";
            this.id = id;
            FirstName.Text = user.Rows[0]["FirstName"].ToString();
            LastName.Text = user.Rows[0]["LastName"].ToString();
            EmailText.Text = user.Rows[0]["Email"].ToString();

            bool admin = (bool)user.Rows[0]["AdminAccess"];

            if (admin)
            {
                AdminPrivilege.SelectedIndex = 0;
            }
            else
            {
                AdminPrivilege.SelectedIndex = 1;
            }

            AddUserBtn.Click -= AddUserBtn_Click;
            AddUserBtn.Click += SaveUserBtn_Click;
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(FirstName.Text.Length <= 0)
                    throw new Exception();

                if (LastName.Text.Length <= 0)
                    throw new Exception();

                if (Password.Text.Length <= 0)
                    throw new Exception();

                if(AdminPrivilege.SelectedIndex == -1)
                    throw new Exception();

                if (EmailText.Text.Length <= 0)
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Complete all the information");
                return;
            }

            bool admin = AdminPrivilege.SelectedItem.ToString().Equals("Yes");

            MySql sql = new MySql();
            sql.OpenConnection();

            if(sql.AddUser(FirstName.Text,LastName.Text,Password.Text,admin, EmailText.Text))
            {
                MessageBox.Show("User Successfully Added");
                sql.CloseConnection();
                DialogResult = DialogResult.OK;
                Close();
            }

            
        }

        private void SaveUserBtn_Click(object sender, EventArgs e)
        {
            bool changePass = false;

            try
            {
                if (FirstName.Text.Length <= 0)
                    throw new Exception();

                if (LastName.Text.Length <= 0)
                    throw new Exception();

                if (Password.Text.Length > 0)
                    changePass = true;

                if (AdminPrivilege.SelectedIndex == -1)
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Complete all the information");
                return;
            }

            bool admin = AdminPrivilege.SelectedItem.ToString().Equals("Yes");

            MySql sql = new MySql();
            sql.OpenConnection();

            if (changePass)
            {
                if (!sql.EditUser(id,FirstName.Text, LastName.Text, admin, Password.Text)) return;
                MessageBox.Show("User Information Successfully Changed");
                sql.CloseConnection();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                if (!sql.EditUser(id,FirstName.Text, LastName.Text, admin)) return;
                MessageBox.Show("User Information Successfully Changed");
                sql.CloseConnection();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
