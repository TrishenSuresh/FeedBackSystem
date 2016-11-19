using System;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class MoreInfoHeader : Form
    {
        public MoreInfoHeader()
        {
            InitializeComponent();
        }

        public MoreInfoHeader(Header header)
        {
            InitializeComponent();

            HeaderName.Text = @"Header Name : " + header.Title;
            HeaderDesc.Text = @"Header Description : " + header.Desc;

            foreach (HeaderItem item in header.HeaderItems)
            {
                HeaderPlace.AddItem(item);
            }

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
