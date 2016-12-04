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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the list of pairs of codes";
            // 
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(169, 125);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(243, 104);
            this.CodeBox.TabIndex = 3;
            this.CodeBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Not Comment*";
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoSize = true;
            this.SaveBtn.Location = new System.Drawing.Point(367, 253);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(81, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save Section";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SectionTitleLabel
            // 
            this.SectionTitleLabel.AutoSize = true;
            this.SectionTitleLabel.Location = new System.Drawing.Point(45, 23);
            this.SectionTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SectionTitleLabel.Name = "SectionTitleLabel";
            this.SectionTitleLabel.Size = new System.Drawing.Size(66, 13);
            this.SectionTitleLabel.TabIndex = 4;
            this.SectionTitleLabel.Text = "Section Title";
            // 
            // SectionDescLabel
            // 
            this.SectionDescLabel.AutoSize = true;
            this.SectionDescLabel.Location = new System.Drawing.Point(45, 51);
            this.SectionDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SectionDescLabel.Name = "SectionDescLabel";
            this.SectionDescLabel.Size = new System.Drawing.Size(99, 13);
            this.SectionDescLabel.TabIndex = 5;
            this.SectionDescLabel.Text = "Section Description";
            // 
            // SectionDescText
            // 
            this.SectionDescText.Location = new System.Drawing.Point(169, 49);
            this.SectionDescText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SectionDescText.Multiline = true;
            this.SectionDescText.Name = "SectionDescText";
            this.SectionDescText.Size = new System.Drawing.Size(243, 45);
            this.SectionDescText.TabIndex = 2;
            // 
            // SectionTitleText
            // 
            this.SectionTitleText.Location = new System.Drawing.Point(169, 19);
            this.SectionTitleText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SectionTitleText.Name = "SectionTitleText";
            this.SectionTitleText.Size = new System.Drawing.Size(243, 20);
            this.SectionTitleText.TabIndex = 1;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(286, 253);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SectionCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 296);
            this.ControlBox = false;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SectionTitleText);
            this.Controls.Add(this.SectionDescText);
            this.Controls.Add(this.SectionDescLabel);
            this.Controls.Add(this.SectionTitleLabel);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button CancelBtn;
    }
}