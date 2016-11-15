using System;
using System.Windows.Forms;
using System.Collections.Generic;
using FeedBackSystem.HeaderCreatorControls;

namespace FeedBackSystem
{
    public partial class HeaderCreator : Form
    {

        Header header;

        public HeaderCreator()
        {
            InitializeComponent();
            this.header = new Header();
            foreach (HeaderItem item in header.HeaderItems)
            {
                HeaderTab.AddItem(item);
            }
        }


        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            using (HeaderItemCreator creator = new HeaderItemCreator())
            {
                var result = creator.ShowDialog();

                if (result == DialogResult.OK)
                {
                    HeaderItem item;
                    if (creator.ValueItem.Count > 1)
                    {
                        item = new HeaderItem(creator.Title + ":", creator.InputType, creator.ValueItem);
                    }
                    else
                    {
                        item = new HeaderItem(creator.Title + ":", creator.InputType, creator.ValueItem[0]);
                    }
                    header.addHeaderItem(item);

                    HeaderTab.AddItem(item);

                }
            }
           
        }

        private void SaveHeaderBtn_Click(object sender, EventArgs e)
        {
            using (SaveBox box = new SaveBox())
            {
                var result = box.ShowDialog();

                if (result == DialogResult.OK)
                {
                    header.Title = box.headerTitle;
                    header.Desc = box.headerDesc;

                    MySql sql = new MySql();
                    sql.OpenConnection();
                    if (sql.SaveHeader(header))
                        MessageBox.Show("Sucessfully inserted into the database");
                    else
                        return;

                    sql.CloseConnection();
                }
            } //using savebox

            //after the saving is done, go back to the home page showing the list of available headers
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            List<int> indexs = new List<int>();
            List<string> names = new List<string>();
            int count = header.HeaderItems.Count;
            for(int x = 4; x < count; x++)
            {
                indexs.Add(x+1);
                names.Add(header.HeaderItems[x].Title);
            }

            using (DeleteBox box = new DeleteBox(indexs,names))
            {
                var result = box.ShowDialog();

                if (result == DialogResult.OK)
                {
                    header.removeHeaderItem(box.deleteIndex-1);
                    HeaderTab.ResetTable();
                    foreach(HeaderItem items in header.HeaderItems)
                    {
                        HeaderTab.AddItem(items);
                    }
                }
            } //using deletebox
        }
    }
}
