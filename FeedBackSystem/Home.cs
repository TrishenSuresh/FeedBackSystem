using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class Home : System.Windows.Forms.UserControl
    {
        public Home()
        {
            InitializeComponent();
            welcome.Text = @"Welcome " + Reviewer.Name;
            
        }
    }
}
