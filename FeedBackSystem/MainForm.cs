using System;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainPanel.Controls.Add(new Home());
        }

        private void giveFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            GenerateFeedback usercontroller = new GenerateFeedback {Dock = DockStyle.Fill};
            MainPanel.Controls.Add(usercontroller);
        }

        private void headerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (HeaderCreator creator = new HeaderCreator())
            {
                creator.ShowDialog();
            }

        }
    }
}
