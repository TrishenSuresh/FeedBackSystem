using System;
using System.Windows.Forms;
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
                    
                    HeaderItem item = new HeaderItem(creator.Title+":",creator.InputType,creator.ValueItem);
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

                    sql.CloseConnection();
                }
            }
        }
    }
}
