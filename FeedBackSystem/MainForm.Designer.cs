namespace FeedBackSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Exit = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.templateToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BackHome = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.435897F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.5641F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.Exit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Menu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BackHome, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.532967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.46703F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1231, 675);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Exit.Location = new System.Drawing.Point(1179, 654);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(28, 21);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Menu
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Menu, 3);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1209, 29);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headerToolStrip,
            this.sectionToolStrip,
            this.templateToolStrip});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.fileToolStripMenuItem.Text = "Review";
            // 
            // headerToolStrip
            // 
            this.headerToolStrip.Name = "headerToolStrip";
            this.headerToolStrip.Size = new System.Drawing.Size(123, 22);
            this.headerToolStrip.Text = "Header";
            this.headerToolStrip.Click += new System.EventHandler(this.headerToolStrip_Click);
            // 
            // sectionToolStrip
            // 
            this.sectionToolStrip.Name = "sectionToolStrip";
            this.sectionToolStrip.Size = new System.Drawing.Size(123, 22);
            this.sectionToolStrip.Text = "Section";
            this.sectionToolStrip.Click += new System.EventHandler(this.sectionToolStrip_Click);
            // 
            // templateToolStrip
            // 
            this.templateToolStrip.Name = "templateToolStrip";
            this.templateToolStrip.Size = new System.Drawing.Size(123, 22);
            this.templateToolStrip.Text = "Template";
            this.templateToolStrip.Click += new System.EventHandler(this.templateToolStrip_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giveFeedbackToolStripMenuItem});
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            // 
            // giveFeedbackToolStripMenuItem
            // 
            this.giveFeedbackToolStripMenuItem.Name = "giveFeedbackToolStripMenuItem";
            this.giveFeedbackToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.giveFeedbackToolStripMenuItem.Text = "Generate Feedback";
            this.giveFeedbackToolStripMenuItem.Click += new System.EventHandler(this.giveFeedbackToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportIssueToolStripMenuItem,
            this.creatorsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 25);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // reportIssueToolStripMenuItem
            // 
            this.reportIssueToolStripMenuItem.Name = "reportIssueToolStripMenuItem";
            this.reportIssueToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.reportIssueToolStripMenuItem.Text = "Report Issue";
            // 
            // creatorsToolStripMenuItem
            // 
            this.creatorsToolStripMenuItem.Name = "creatorsToolStripMenuItem";
            this.creatorsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.creatorsToolStripMenuItem.Text = "Creators";
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.MainPanel, 2);
            this.MainPanel.Location = new System.Drawing.Point(19, 32);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1187, 619);
            this.MainPanel.TabIndex = 1;
            // 
            // BackHome
            // 
            this.BackHome.AutoSize = true;
            this.BackHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.BackHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BackHome.Location = new System.Drawing.Point(1098, 654);
            this.BackHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BackHome.Name = "BackHome";
            this.BackHome.Size = new System.Drawing.Size(72, 21);
            this.BackHome.TabIndex = 2;
            this.BackHome.Text = "Back Home";
            this.BackHome.Click += new System.EventHandler(this.BackHome_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 675);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "Feedback Generating System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headerToolStrip;
        private System.Windows.Forms.ToolStripMenuItem sectionToolStrip;
        private System.Windows.Forms.ToolStripMenuItem templateToolStrip;
        private System.Windows.Forms.Label BackHome;
        private System.Windows.Forms.Label Exit;
    }
}

