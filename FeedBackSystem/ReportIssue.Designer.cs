namespace FeedBackSystem
{
    partial class ReportIssue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.Label();
            this.SubjectText = new System.Windows.Forms.TextBox();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BodyText = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(24, 26);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(91, 20);
            this.NameLabel.TabIndex = 99;
            this.NameLabel.Text = "Your name:";
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Location = new System.Drawing.Point(148, 26);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(120, 20);
            this.NameText.TabIndex = 98;
            this.NameText.Text = "Reviewer Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(24, 50);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(113, 20);
            this.EmailLabel.TabIndex = 97;
            this.EmailLabel.Text = "Email address:";
            // 
            // EmailText
            // 
            this.EmailText.AutoSize = true;
            this.EmailText.Location = new System.Drawing.Point(148, 50);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(111, 20);
            this.EmailText.TabIndex = 96;
            this.EmailText.Text = "Email Address";
            // 
            // SubjectText
            // 
            this.SubjectText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectText.Location = new System.Drawing.Point(129, 84);
            this.SubjectText.MaxLength = 99;
            this.SubjectText.Name = "SubjectText";
            this.SubjectText.Size = new System.Drawing.Size(481, 26);
            this.SubjectText.TabIndex = 1;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(28, 90);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(63, 20);
            this.SubjectLabel.TabIndex = 5;
            this.SubjectLabel.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 95;
            this.label1.Text = "Body";
            // 
            // BodyText
            // 
            this.BodyText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BodyText.Location = new System.Drawing.Point(129, 131);
            this.BodyText.Multiline = true;
            this.BodyText.Name = "BodyText";
            this.BodyText.Size = new System.Drawing.Size(482, 143);
            this.BodyText.TabIndex = 2;
            // 
            // SendBtn
            // 
            this.SendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBtn.Location = new System.Drawing.Point(515, 292);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(96, 36);
            this.SendBtn.TabIndex = 3;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // ReportIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.BodyText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.SubjectText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.NameLabel);
            this.Name = "ReportIssue";
            this.Size = new System.Drawing.Size(632, 343);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label EmailText;
        private System.Windows.Forms.TextBox SubjectText;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BodyText;
        private System.Windows.Forms.Button SendBtn;
    }
}
