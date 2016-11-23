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

        public void SetValue(string s)
        {
            TextBox.Text = s;
        }

    }
}
