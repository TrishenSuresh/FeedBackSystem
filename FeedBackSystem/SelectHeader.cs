using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FeedBackSystem
{
    public partial class SelectHeader : Form
    {
        public Header Header;
        public List<Header> _headers = new List<Header>();

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
                _headers.Add(new Header(row["HeaderID"].ToString(),row["Name"].ToString(),row["Desc"].ToString()));
            }


            //Get the header Items
            foreach (Header h in _headers)
            {

                List<HeaderItem> headerItemList = sql.GetHeaderItems(h.HeaderID);

                foreach (var item in headerItemList)
                {
                    h.addHeaderItem(item);
                }
                
                
                //Display the headers information
                Button moreInfoButton = new Button { Text = @"More Info", Name = h.HeaderID };
                moreInfoButton.Click += new EventHandler(MoreInfobutton_Click);
                Button selectButton = new Button { Text = @"Select", Name = h.HeaderID };
                selectButton.Click += new EventHandler(Selectbutton_Click);

                HeaderList.Controls.Add(new Label { Text = h.Title,TextAlign = ContentAlignment.MiddleLeft, AutoSize = true }, 0, rowCounter);
                HeaderList.Controls.Add(new Label { Text = h.Desc, TextAlign = ContentAlignment.MiddleLeft, AutoSize = true },1, rowCounter);
                HeaderList.Controls.Add(moreInfoButton, 2,rowCounter);
                HeaderList.Controls.Add(selectButton, 3, rowCounter);

                rowCounter++;
            }

            sql.CloseConnection();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {

        }

        protected void MoreInfobutton_Click(object sender, System.EventArgs e)
        {
            Button button = sender as Button;

            if (button == null) return;

            Header = _headers.Find(x => x.HeaderID == button.Name);

            MoreInfoHeader moreInfo = new MoreInfoHeader(Header);

            moreInfo.ShowDialog();
        }

        protected void Selectbutton_Click(object sender, System.EventArgs e)
        {
            Button button = sender as Button;

            if (button == null) return;

            Header = _headers.Find(x => x.HeaderID == button.Name);

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
