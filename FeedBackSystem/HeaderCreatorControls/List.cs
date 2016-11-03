using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBackSystem.HeaderCreatorControls
{
    public partial class List : UserControl
    {
        public List()
        {
            InitializeComponent();
        }

        public List<string> GetValue()
        {
            List<string> list = new List<string>(ListBox.Lines);
            list.RemoveAll(item => item.Length == 0);

            return list;
        }
    }
}
