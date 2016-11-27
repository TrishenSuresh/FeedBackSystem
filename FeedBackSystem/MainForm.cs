using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FeedBackSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            MainPanel.Controls.Add(new Home());

            var adobePath = Registry.GetValue(@"HKEY_CLASSES_ROOT\Software\Adobe\Acrobat\Exe", string.Empty, string.Empty);

            if (adobePath == null)
            {
                MessageBox.Show("Please install adobe reader to fully utilize the system's functionality","Adobe Reader Not Found",MessageBoxButtons.OK);
            }

            if (Reviewer.IsAdmin)
            {
                ToolStripMenuItem AdminButton = new ToolStripMenuItem("Admin");
                Menu.Items.Add(AdminButton);
                ToolStripMenuItem button = new ToolStripMenuItem("Users List");
                button.Click += UserListBtn;
                AdminButton.DropDownItems.Add(button);
            }
        }

        private void UserListBtn(object sender, EventArgs eventArgs)
        {
            new UserList().ShowDialog();
        }

        private void giveFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            GenerateFeedback usercontroller = new GenerateFeedback {Dock = DockStyle.Fill};
            MainPanel.Controls.Add(usercontroller);
        }

        private void headerToolStrip_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            DisplayControl display = new DisplayControl("Header") { Dock = DockStyle.Fill };
            MainPanel.Controls.Add(display);
        }

        private void sectionToolStrip_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            DisplayControl display = new DisplayControl("Section") { Dock = DockStyle.Fill };
            MainPanel.Controls.Add(display);
        }

        private void templateToolStrip_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            DisplayControl display = new DisplayControl("Template") { Dock = DockStyle.Fill };
            MainPanel.Controls.Add(display);
        }
    }
}
