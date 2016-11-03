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
                    return "Review";
                }
                else
                {
                    if (ManualRadio.Checked)
                    {
                        return "Manual";
                    }
                }
            }

            return null;
        }
    }
}
