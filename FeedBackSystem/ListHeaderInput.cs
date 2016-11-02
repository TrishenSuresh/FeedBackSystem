using System;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class ListHeaderInput : Form
    {
        public ListHeaderInput()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
           

        }

        internal void ShowDialog(MessageBoxButtons yesNo)
        {
            throw new NotImplementedException();
        }

        public string[] ReturnList()
        {
            return ListBox.Lines;
        }

        public string ReturnListName()
        {
            return ListName.Text;
        }

       
    }
}
