namespace FeedBackSystem
{
    partial class SectionCreator
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
            this.label1 = new System.Windows.Forms.Label();
            this.CodeBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SectionTitleLabel = new System.Windows.Forms.Label();
            this.SectionDescLabel = new System.Windows.Forms.Label();
            this.SectionDescText = new System.Windows.Forms.TextBox();
            this.SectionTitleText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the list of pairs of codes";
            // 
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(253, 193);
            this.CodeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(362, 158);
            this.CodeBox.TabIndex = 3;
            this.CodeBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Not Comment*";
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoSize = true;
            this.SaveBtn.Location = new System.Drawing.Point(550, 389);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(122, 35);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save Section";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SectionTitleLabel
            // 
            this.SectionTitleLabel.AutoSize = true;
            this.SectionTitleLabel.Location = new System.Drawing.Point(67, 35);
            this.SectionTitleLabel.Name = "SectionTitleLabel";
            this.SectionTitleLabel.Size = new System.Drawing.Size(96, 20);
            this.SectionTitleLabel.TabIndex = 4;
            this.SectionTitleLabel.Text = "Section Title";
            // 
            // SectionDescLabel
            // 
            this.SectionDescLabel.AutoSize = true;
            this.SectionDescLabel.Location = new System.Drawing.Point(67, 78);
            this.SectionDescLabel.Name = "SectionDescLabel";
            this.SectionDescLabel.Size = new System.Drawing.Size(147, 20);
            this.SectionDescLabel.TabIndex = 5;
            this.SectionDescLabel.Text = "Section Description";
            // 
            // SectionDescText
            // 
            this.SectionDescText.Location = new System.Drawing.Point(253, 75);
            this.SectionDescText.Multiline = true;
            this.SectionDescText.Name = "SectionDescText";
            this.SectionDescText.Size = new System.Drawing.Size(362, 67);
            this.SectionDescText.TabIndex = 2;
            // 
            // SectionTitleText
            // 
            this.SectionTitleText.Location = new System.Drawing.Point(253, 29);
            this.SectionTitleText.Name = "SectionTitleText";
            this.SectionTitleText.Size = new System.Drawing.Size(362, 26);
            this.SectionTitleText.TabIndex = 1;
            // 
            // SectionCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 456);
            this.Controls.Add(this.SectionTitleText);
            this.Controls.Add(this.SectionDescText);
            this.Controls.Add(this.SectionDescLabel);
            this.Controls.Add(this.SectionTitleLabel);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SectionCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Section";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox CodeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label SectionTitleLabel;
        private System.Windows.Forms.Label SectionDescLabel;
        private System.Windows.Forms.TextBox SectionDescText;
        private System.Windows.Forms.TextBox SectionTitleText;
    }
}