using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBackSystem.HeaderControls
{
    public partial class List : UserControl
    {
        public List()
        {
            InitializeComponent();
        }

        public List(string title, List<string> input)
        {
            InitializeComponent();

            ListTitle.Text = title;

            foreach (string s in input)
            {
                ListBox.Items.Add(s);
            }
        }
    }
}
