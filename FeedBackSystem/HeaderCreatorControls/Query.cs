using System;
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
            switch (QueryList.Text)
            {
                case "Applicant - Email":
                    return "<Applicant Email>";
                case "Application Status":
                    return "<Application Status>";
                default:
                    throw new Exception("You have to make a selection!");
            }
        }
    }
}
