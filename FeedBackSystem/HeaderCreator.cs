using System;
using System.Windows.Forms;
using System.Collections.Generic;

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

        public HeaderCreator(string id)
        {
            InitializeComponent();
            
            MySql sql = new MySql();
            sql.OpenConnection();

            header = sql.GetHeader(id);

            List<HeaderItem> items = sql.GetHeaderItems(id);

            foreach (HeaderItem item in items)
            {
                HeaderTab.AddItem(item);
            }

            TitleText.Text = header.Title;
            DescText.Text = header.Desc;

            sql.CloseConnection();
        }


        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            using (HeaderItemCreator creator = new HeaderItemCreator())
            {
                var result = creator.ShowDialog();

                if (result == DialogResult.OK)
                {
                    HeaderItem item = new HeaderItem(creator.Title + ":", creator.InputType, creator.ValueItem);
                    header.addHeaderItem(item);

                    HeaderTab.AddItem(item);
                }
            }
        }

        private void SaveHeaderBtn_Click(object sender, EventArgs e)
        {

            header.HeaderItems = HeaderTab._headeritems;
            
            header.Title = TitleText.Text;
            header.Desc = DescText.Text;

            if(String.IsNullOrEmpty(header.Title))
            {
                MessageBox.Show("The Header Title must not be empty!", "Missing attributes");
                return;
            }

            MySql sql = new MySql();
            sql.OpenConnection();
            if (sql.SaveHeader(header))
                MessageBox.Show("Sucessfully inserted into the database");
            else
                return;

            sql.CloseConnection();
        
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
