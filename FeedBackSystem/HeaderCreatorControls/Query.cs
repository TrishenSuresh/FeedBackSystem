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
    public partial class Query : UserControl
    {
        public Query()
        {
            InitializeComponent();
        }

        public string GetValue()
        {
            string sqlStatement = "";
            switch (QueryList.Text)
            {
                case "Applicant - Email":
                    sqlStatement = "SELECT Email as title FROM applicant";
                    break;
                case "Application Status":
                    sqlStatement = "SELECT StatusTitle as title FROM applicationstatus";
                    break;
            }
            return sqlStatement;
        }
    }
}
