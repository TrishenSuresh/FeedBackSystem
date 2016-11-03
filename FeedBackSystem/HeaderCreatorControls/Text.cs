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
    public partial class Text : UserControl
    {
        public Text()
        {
            InitializeComponent();
        }

        public string GetValue()
        {
            return TextBox.Text;
        }
    }
}
