using System.Windows.Forms;

namespace FeedBackSystem.HeaderCreatorControls
{
    public partial class Date : UserControl
    {
        public Date()
        {
            InitializeComponent();
        }

        public string GetValue()
        {
            if (TodayRadio.Checked)
            {
                return "Today";
            }
            else
            {
                if (Review_InterviewRadio.Checked)
                {
                    return "<Review Date>"; //will be set to query
                }
                else
                {
                    if (ManualRadio.Checked)
                    {
                        return "Manual";
                    }
                    else
                    {
                        throw new System.Exception("You have to make a selection!");
                    }
                }
            }
        }
    }
}
