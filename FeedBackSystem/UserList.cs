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
    public partial class UserList : UserControl
    {
        public UserList()
        {
            InitializeComponent();
            UpdateUserList();
           
        }

        private void UserDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UserDGV.SelectedRows.Count > 1)
            {
                DeleteBtn.Text = "Delete Users";
                EditBtn.Enabled = false;
            }
            else
            {
                DeleteBtn.Text = "Delete User";
                EditBtn.Enabled = true;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (UserInfo form = new UserInfo("Add User"))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    UpdateUserList();
                }
            }
        }

        private void UpdateUserList()
        {
            MySql sql = new MySql();

            sql.OpenConnection();

            DataTable users =
                sql.GetDataSet(
                    "SELECT ReviewerID, FirstName, LastName, IF(AdminAccess = 1, \'yes\', \'no\') as AdminAccess FROM feedbacksystem.reviewer where Archived = 0;");

            UserDGV.DataSource = users;

            for (int a = 0; a < UserDGV.ColumnCount - 2; a++)
            {
                UserDGV.Columns[a].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            UserDGV.Columns[UserDGV.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            sql.CloseConnection();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            List<string> ids = new List<string>();

            MySql sql = new MySql();
            sql.OpenConnection();

            if (UserDGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in UserDGV.SelectedRows)
                {
                    ids.Add(row.Cells[0].Value.ToString());
                }

                var confirmResult =  MessageBox.Show("Are you sure you want to delete the users with the following ids:\n" +
                                    string.Join(", ", ids), "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult != DialogResult.Yes)
                {
                    return;
                } else
                {
                    foreach (string s in ids)
                    {
                        sql.ArchiveUser(s);
                    }

                    MessageBox.Show("Successfully Deleted");

                    UpdateUserList();
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            
            if (UserDGV.SelectedCells.Count > 0)
            {
                int selectedrowindex = UserDGV.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = UserDGV.Rows[selectedrowindex];

                string id = Convert.ToString(selectedRow.Cells["ReviewerID"].Value);

                using (UserInfo form = new UserInfo(id, "Update User"))
                {
                    var result = form.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        UpdateUserList();
                    }
                }
            }


            }
    }
}
