﻿using System;
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
            BackHome.Visible = false;

            var adobePath = Registry.GetValue(@"HKEY_CLASSES_ROOT\Software\Adobe\Acrobat\Exe", string.Empty, string.Empty);

            if (adobePath == null)
            {
                MessageBox.Show("Please install adobe reader to fully utilize the system's functionality","Adobe Reader Not Found",MessageBoxButtons.OK);
            }

            TempFileHandler.CleanTempFile();

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
            MainPanel.Controls.Clear();
            UserList ul = new UserList { Dock = DockStyle.Fill };
            MainPanel.Controls.Add(ul);
            BackHome.Visible = true;
        }

        private void giveFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            GenerateFeedback usercontroller = new GenerateFeedback {Dock = DockStyle.Fill};
            MainPanel.Controls.Add(usercontroller);
            BackHome.Visible = true;
        }

        private void headerToolStrip_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            DisplayControl display = new DisplayControl("Header") { Dock = DockStyle.Fill };
            MainPanel.Controls.Add(display);
            BackHome.Visible = true;
        }

        private void sectionToolStrip_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            DisplayControl display = new DisplayControl("Section") { Dock = DockStyle.Fill };
            MainPanel.Controls.Add(display);
            BackHome.Visible = true;
        }

        private void templateToolStrip_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            DisplayControl display = new DisplayControl("Template") { Dock = DockStyle.Fill };
            MainPanel.Controls.Add(display);
            BackHome.Visible = true;
        }

        private void BackHome_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Home());
            BackHome.Visible = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exiting System", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TempFileHandler.CleanTempSession();
        }

        private void reportIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            ReportIssue report = new ReportIssue() { Dock = DockStyle.Fill };
            MainPanel.Controls.Add(report);
            BackHome.Visible = true;
        }

        private void creatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Creator creator = new Creator() { Dock = DockStyle.Fill };
            MainPanel.Controls.Add(creator);
            BackHome.Visible = true;
        }
    }
}
