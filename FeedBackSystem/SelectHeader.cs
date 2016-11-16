using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class SelectHeader : Form
    {
        public Header Header;
        public List<Header> Headers = new List<Header>();

        public SelectHeader()
        {
            

            InitializeComponent();
            MySql sql = new MySql();
            sql.OpenConnection();
            int rowCounter = 1;
          

            //Collect all the headers
            DataTable header = sql.GetDataSet("SELECT * FROM feedbacksystem.header");

            //Add the headers into HeaderList
            foreach (DataRow row in header.Rows)
            {
                Headers.Add(new Header(row["HeaderID"].ToString(),row["Name"].ToString(),row["Desc"].ToString()));
            }


            //Get the header Items
            foreach (Header h in Headers)
            {

                List<HeaderItem> headerItemList = sql.GetHeaderItems(h.HeaderId);

                foreach (var item in headerItemList)
                {
                    h.addHeaderItem(item);
                }
                
                
                //Display the headers information
                Button moreInfoButton = new Button { Text = @"More Info", Name = h.HeaderId };
                moreInfoButton.Click += MoreInfobutton_Click;
                Button selectButton = new Button { Text = @"Select", Name = h.HeaderId };
                selectButton.Click += Selectbutton_Click;

                HeaderList.Controls.Add(new Label { Text = h.Title,TextAlign = ContentAlignment.MiddleLeft, AutoSize = true }, 0, rowCounter);
                HeaderList.Controls.Add(new Label { Text = h.Desc, TextAlign = ContentAlignment.MiddleLeft, AutoSize = true },1, rowCounter);
                HeaderList.Controls.Add(moreInfoButton, 2,rowCounter);
                HeaderList.Controls.Add(selectButton, 3, rowCounter);

                rowCounter++;
            }

            sql.CloseConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        protected void MoreInfobutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button == null) return;

            Header = Headers.Find(x => x.HeaderId == button.Name);

            MoreInfoHeader moreInfo = new MoreInfoHeader(Header);

            moreInfo.ShowDialog();
        }

        protected void Selectbutton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button == null) return;

            Header = Headers.Find(x => x.HeaderId == button.Name);

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
