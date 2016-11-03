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
    public partial class Date : UserControl
    {
        public Date()
        {
            InitializeComponent();
        }

        public Date(string date)
        {
            DatePicker.Value = Convert.ToDateTime(date);
        }
    }
}
