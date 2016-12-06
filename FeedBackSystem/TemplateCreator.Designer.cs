namespace FeedBackSystem
{
    partial class TemplateCreator
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
            this.ChangeHeader = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescText = new System.Windows.Forms.TextBox();
            this.SaveTemplate = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.AddHeaderBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.HorizontalLine = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.Sections = new FeedBackSystem.SectionSelection();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeHeader
            // 
            this.ChangeHeader.AutoSize = true;
            this.ChangeHeader.Enabled = false;
            this.ChangeHeader.Location = new System.Drawing.Point(1147, 715);
            this.ChangeHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeHeader.Name = "ChangeHeader";
            this.ChangeHeader.Size = new System.Drawing.Size(138, 35);
            this.ChangeHeader.TabIndex = 0;
            this.ChangeHeader.Text = "Change Header";
            this.ChangeHeader.UseVisualStyleBackColor = true;
            this.ChangeHeader.Click += new System.EventHandler(this.AddHeaderBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Template Title:";
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(136, 22);
            this.TitleText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(238, 26);
            this.TitleText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Template Description:";
            // 
            // DescText
            // 
            this.DescText.Location = new System.Drawing.Point(603, 22);
            this.DescText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DescText.Name = "DescText";
            this.DescText.Size = new System.Drawing.Size(394, 26);
            this.DescText.TabIndex = 13;
            // 
            // SaveTemplate
            // 
            this.SaveTemplate.AutoSize = true;
            this.SaveTemplate.Location = new System.Drawing.Point(1297, 715);
            this.SaveTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 10, 9);
            this.SaveTemplate.Name = "SaveTemplate";
            this.SaveTemplate.Size = new System.Drawing.Size(134, 35);
            this.SaveTemplate.TabIndex = 14;
            this.SaveTemplate.Text = "Save Template";
            this.SaveTemplate.UseVisualStyleBackColor = true;
            this.SaveTemplate.Click += new System.EventHandler(this.SaveTemplateBtn_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.AddHeaderBtn);
            this.HeaderPanel.Location = new System.Drawing.Point(13, 125);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1419, 168);
            this.HeaderPanel.TabIndex = 15;
            // 
            // AddHeaderBtn
            // 
            this.AddHeaderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddHeaderBtn.Location = new System.Drawing.Point(0, 0);
            this.AddHeaderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddHeaderBtn.Name = "AddHeaderBtn";
            this.AddHeaderBtn.Size = new System.Drawing.Size(1419, 168);
            this.AddHeaderBtn.TabIndex = 1;
            this.AddHeaderBtn.Text = "Add Header";
            this.AddHeaderBtn.UseVisualStyleBackColor = true;
            this.AddHeaderBtn.Click += new System.EventHandler(this.AddHeaderBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(999, 715);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 10, 9);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(134, 35);
            this.CancelBtn.TabIndex = 17;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // HorizontalLine
            // 
            this.HorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalLine.Location = new System.Drawing.Point(-9, 105);
            this.HorizontalLine.Name = "HorizontalLine";
            this.HorizontalLine.Size = new System.Drawing.Size(1470, 15);
            this.HorizontalLine.TabIndex = 18;
            this.HorizontalLine.Visible = false;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(10, 85);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(456, 20);
            this.TextLabel.TabIndex = 19;
            this.TextLabel.Text = "How the header would look like during the generating feedback:";
            this.TextLabel.Visible = false;
            // 
            // Sections
            // 
            this.Sections.Location = new System.Drawing.Point(15, 317);
            this.Sections.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Sections.Name = "Sections";
            this.Sections.Size = new System.Drawing.Size(1440, 385);
            this.Sections.TabIndex = 20;
            // 
            // TemplateCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1459, 808);
            this.ControlBox = false;
            this.Controls.Add(this.Sections);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.HorizontalLine);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ChangeHeader);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.SaveTemplate);
            this.Controls.Add(this.DescText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TemplateCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Template";
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChangeHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescText;
        private System.Windows.Forms.Button SaveTemplate;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label HorizontalLine;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Button AddHeaderBtn;
        private SectionSelection Sections;
    }
}