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
            this.AddHeaderBtn = new System.Windows.Forms.Button();
            this.ChangeHeader = new System.Windows.Forms.Button();
            this.ChangeSectionBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescText = new System.Windows.Forms.TextBox();
            this.SaveTemplate = new System.Windows.Forms.Button();
            this.SectionTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddSectionBtn = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.SectionPanel = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.HorizontalLine = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.SectionTable.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddHeaderBtn
            // 
            this.AddHeaderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddHeaderBtn.Location = new System.Drawing.Point(0, 0);
            this.AddHeaderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddHeaderBtn.Name = "AddHeaderBtn";
            this.AddHeaderBtn.Size = new System.Drawing.Size(1361, 168);
            this.AddHeaderBtn.TabIndex = 0;
            this.AddHeaderBtn.Text = "Add Header";
            this.AddHeaderBtn.UseVisualStyleBackColor = true;
            this.AddHeaderBtn.Click += new System.EventHandler(this.AddHeaderBtn_Click);
            // 
            // ChangeHeader
            // 
            this.ChangeHeader.AutoSize = true;
            this.ChangeHeader.Location = new System.Drawing.Point(1237, 308);
            this.ChangeHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeHeader.Name = "ChangeHeader";
            this.ChangeHeader.Size = new System.Drawing.Size(138, 38);
            this.ChangeHeader.TabIndex = 0;
            this.ChangeHeader.Text = "Change Header";
            this.ChangeHeader.UseVisualStyleBackColor = true;
            this.ChangeHeader.Visible = false;
            this.ChangeHeader.Click += new System.EventHandler(this.AddHeaderBtn_Click);
            // 
            // ChangeSectionBtn
            // 
            this.ChangeSectionBtn.AutoSize = true;
            this.ChangeSectionBtn.Location = new System.Drawing.Point(1241, 860);
            this.ChangeSectionBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeSectionBtn.Name = "ChangeSectionBtn";
            this.ChangeSectionBtn.Size = new System.Drawing.Size(134, 38);
            this.ChangeSectionBtn.TabIndex = 9;
            this.ChangeSectionBtn.Text = "Change Section";
            this.ChangeSectionBtn.UseVisualStyleBackColor = true;
            this.ChangeSectionBtn.Visible = false;
            this.ChangeSectionBtn.Click += new System.EventHandler(this.AddSectionBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Template Title:";
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(137, 21);
            this.TitleText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(238, 26);
            this.TitleText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Template Description:";
            // 
            // DescText
            // 
            this.DescText.Location = new System.Drawing.Point(603, 21);
            this.DescText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DescText.Name = "DescText";
            this.DescText.Size = new System.Drawing.Size(394, 26);
            this.DescText.TabIndex = 13;
            // 
            // SaveTemplate
            // 
            this.SaveTemplate.AutoSize = true;
            this.SaveTemplate.Location = new System.Drawing.Point(1241, 915);
            this.SaveTemplate.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.SaveTemplate.Name = "SaveTemplate";
            this.SaveTemplate.Size = new System.Drawing.Size(134, 35);
            this.SaveTemplate.TabIndex = 14;
            this.SaveTemplate.Text = "Save Template";
            this.SaveTemplate.UseVisualStyleBackColor = true;
            this.SaveTemplate.Click += new System.EventHandler(this.SaveTemplateBtn_Click);
            // 
            // SectionTable
            // 
            this.SectionTable.AutoScroll = true;
            this.SectionTable.AutoScrollMinSize = new System.Drawing.Size(5, 0);
            this.SectionTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SectionTable.ColumnCount = 3;
            this.SectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SectionTable.Controls.Add(this.AddSectionBtn, 1, 0);
            this.SectionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionTable.Location = new System.Drawing.Point(0, 0);
            this.SectionTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SectionTable.Name = "SectionTable";
            this.SectionTable.RowCount = 1;
            this.SectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 494F));
            this.SectionTable.Size = new System.Drawing.Size(1361, 494);
            this.SectionTable.TabIndex = 9;
            // 
            // AddSectionBtn
            // 
            this.AddSectionBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSectionBtn.Location = new System.Drawing.Point(3, 3);
            this.AddSectionBtn.Name = "AddSectionBtn";
            this.AddSectionBtn.Size = new System.Drawing.Size(1355, 488);
            this.AddSectionBtn.TabIndex = 0;
            this.AddSectionBtn.Text = "Add Section";
            this.AddSectionBtn.UseVisualStyleBackColor = true;
            this.AddSectionBtn.Click += new System.EventHandler(this.AddSectionBtn_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.AddHeaderBtn);
            this.HeaderPanel.Location = new System.Drawing.Point(11, 130);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1361, 168);
            this.HeaderPanel.TabIndex = 15;
            // 
            // SectionPanel
            // 
            this.SectionPanel.Controls.Add(this.SectionTable);
            this.SectionPanel.Location = new System.Drawing.Point(14, 356);
            this.SectionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SectionPanel.Name = "SectionPanel";
            this.SectionPanel.Size = new System.Drawing.Size(1361, 494);
            this.SectionPanel.TabIndex = 16;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(1100, 915);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(134, 35);
            this.CancelBtn.TabIndex = 17;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // HorizontalLine
            // 
            this.HorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalLine.Location = new System.Drawing.Point(-4, 107);
            this.HorizontalLine.Name = "HorizontalLine";
            this.HorizontalLine.Size = new System.Drawing.Size(1400, 2);
            this.HorizontalLine.TabIndex = 18;
            this.HorizontalLine.Visible = false;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(11, 84);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(468, 20);
            this.TextLabel.TabIndex = 19;
            this.TextLabel.Text = "How the template would look like during the generating feedback:";
            this.TextLabel.Visible = false;
            // 
            // TemplateCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1398, 968);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.HorizontalLine);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ChangeHeader);
            this.Controls.Add(this.SectionPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.ChangeSectionBtn);
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
            this.SectionTable.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.SectionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddHeaderBtn;
        private System.Windows.Forms.Button ChangeHeader;
        private System.Windows.Forms.Button ChangeSectionBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescText;
        private System.Windows.Forms.Button SaveTemplate;
        private System.Windows.Forms.TableLayoutPanel SectionTable;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel SectionPanel;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddSectionBtn;
        private System.Windows.Forms.Label HorizontalLine;
        private System.Windows.Forms.Label TextLabel;
    }
}