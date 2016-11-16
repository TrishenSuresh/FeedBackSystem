using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            welcome.Text = @"Welcome " + Reviewer.Name;
            
        }
    }
}
