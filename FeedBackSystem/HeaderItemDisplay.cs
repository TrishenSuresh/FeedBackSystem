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
    public partial class HeaderItemDisplay : Form
    {
        private Header _header;

        public HeaderItemDisplay()
        {
            InitializeComponent();

            for (int a = 0; a < ItemDVG.ColumnCount - 2; a++)
            {
                ItemDVG.Columns[a].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            ItemDVG.Columns[ItemDVG.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            _header = new Header();

            refreshGrid();
        }

        public HeaderItemDisplay(string id)
        {

            InitializeComponent();

            MySql sql = new MySql();
            sql.OpenConnection();

            _header = sql.GetHeader(id);
            _header.HeaderItems.Clear();
            List<HeaderItem>items = sql.GetHeaderItems(id);

            foreach (HeaderItem item in items)
            {
                _header.addHeaderItem(item);
            }

            HeaderTitleText.Text = _header.Title;
            HeaderDescText.Text = _header.Desc;

            ItemDVG.DataSource = _header.HeaderItems;

            for (int a = 0; a < ItemDVG.ColumnCount - 2; a++)
            {
                ItemDVG.Columns[a].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            ItemDVG.Columns[ItemDVG.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            sql.CloseConnection();

            SaveHeader.Click -= SaveHeader_Click;
            SaveHeader.Click += UpdateHeader_Click;
            SaveHeader.Text = "Update Header";

        }

        private void ItemDVG_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (ItemDVG.Rows.Count != 0)
            {
                int rowIndex = 0;

                foreach (HeaderItem i in _header.HeaderItems)
                {
                    if (i.ValueItem.Count <= 1)
                    {
                        ItemDVG["Value", rowIndex].Value = i.ValueItem[0];
                        rowIndex++;
                    }
                    else
                    {
                        string str = "";

                        foreach (string s in i.ValueItem)
                        {
                            str += s + " | ";
                        }
                        ItemDVG["Value", rowIndex].Value = str;
                        rowIndex++;
                    }
                }
            }

        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            int rowIndex = ItemDVG.CurrentCell.RowIndex;

            if (rowIndex < 1 || rowIndex <= 4)
            {
                MessageBox.Show("Sorry, you cannot move this up any further");
                return;
            }

            if (rowIndex < 4)
            {
                MessageBox.Show("Sorry, you are not allowed to rearrange this item");
                return;
            }

            HeaderItem item = _header.HeaderItems[rowIndex];
            _header.HeaderItems.RemoveAt(rowIndex);
            _header.HeaderItems.Insert(rowIndex-1,item);
            refreshGrid();
            ItemDVG.CurrentCell = ItemDVG.Rows[rowIndex - 1].Cells[1];
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            
            int rowIndex = ItemDVG.CurrentCell.RowIndex;
            int rowCount = ItemDVG.RowCount;
            if (rowIndex >= rowCount-1)
            {
                MessageBox.Show("Sorry, you cannot move this down any further");
                return;
            }

            if (rowIndex < 4)
            {
                MessageBox.Show("Sorry, you are not allowed to rearrange this item");
                return;
            }

            HeaderItem item = _header.HeaderItems[rowIndex];
            _header.HeaderItems.RemoveAt(rowIndex);
            _header.HeaderItems.Insert(rowIndex + 1, item);
            refreshGrid();
            ItemDVG.CurrentCell = ItemDVG.Rows[rowIndex + 1].Cells[1];
        }

      

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
            int rowIndex = ItemDVG.CurrentCell.RowIndex;

            if (rowIndex < 4)
            {
                MessageBox.Show("Sorry, you are not allowed to delete that");
                return;
            }

            _header.HeaderItems.RemoveAt(rowIndex);
            ItemDVG.CurrentCell = ItemDVG.Rows[rowIndex - 1].Cells[1];
            refreshGrid();
        }

        private void refreshGrid()
        {
            ItemDVG.DataSource = null;
            ItemDVG.Rows.Clear();
            ItemDVG.DataSource = _header.HeaderItems;
            ItemDVG.Refresh();
        }

        private void SaveHeader_Click(object sender, EventArgs e)
        {

            if (HeaderTitleText.Text.Length <= 0)
            {
                MessageBox.Show("Please fill in the title");
                return;
            }

            if (HeaderDescText.Text.Length <= 0)
            {
                MessageBox.Show("Please fill in the description");
                return;
            }

            _header.Title = HeaderTitleText.Text;
            _header.Desc = HeaderDescText.Text;



            MySql sql = new MySql();
            sql.OpenConnection();
            if (sql.SaveHeader(_header))
            {
                MessageBox.Show("Header Successfully Saved");
                this.DialogResult = DialogResult.OK;
                sql.CloseConnection();
                Close();
            }
            sql.CloseConnection();

        }

        private void UpdateHeader_Click(object sender, EventArgs e)
        {

            if (HeaderTitleText.Text.Length <= 0)
            {
                MessageBox.Show("Please fill in the title");
                return;
            }

            if (HeaderDescText.Text.Length <= 0)
            {
                MessageBox.Show("Please fill in the description");
                return;
            }


            _header.Title = HeaderTitleText.Text;
            _header.Desc = HeaderDescText.Text;

            MySql sql = new MySql();
            sql.OpenConnection();

            if (sql.UpdateHeader(_header))
            {
                MessageBox.Show("Header Successfully Saved");
                this.DialogResult = DialogResult.OK;
                Close();
            }


            sql.CloseConnection();

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            using (HeaderItemCreator form = new HeaderItemCreator())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _header.addHeaderItem(form.headitem);
                    refreshGrid();
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = ItemDVG.CurrentCell.RowIndex;

            if (rowIndex < 4)
            {
                MessageBox.Show("Sorry, You are not allowed to edit this.");
                return;
            }

            HeaderItem item = _header.HeaderItems.ElementAt(rowIndex);

            using (HeaderItemCreator form = new HeaderItemCreator(item))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _header.HeaderItems.RemoveAt(rowIndex);
                    _header.HeaderItems.Insert(rowIndex,form.headitem);
                    refreshGrid();
                }
            }
        }

        private void ItemDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = ItemDVG.CurrentCell.RowIndex;

            if (rowIndex < 4)
            {
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
                MoveDown.Enabled = false;
                MoveUp.Enabled = false;
            }
            else
            {
                EditBtn.Enabled = true;
                DeleteBtn.Enabled = true;
                MoveDown.Enabled = true;
                MoveUp.Enabled = true;
            }
        }
    }
}
