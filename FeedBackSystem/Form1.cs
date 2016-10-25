using System;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
