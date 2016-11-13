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
    public partial class MoreInfoHeader : Form
    {
        public MoreInfoHeader()
        {
            InitializeComponent();
        }

        public MoreInfoHeader(Header header)
        {
            InitializeComponent();

            HeaderName.Text = @"Header Name : "+header.Title;

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
