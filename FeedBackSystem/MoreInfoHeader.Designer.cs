namespace FeedBackSystem
{
    partial class MoreInfoHeader
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
            this.Close = new System.Windows.Forms.Button();
            this.HeaderName = new System.Windows.Forms.Label();
            this.HeaderDesc = new System.Windows.Forms.Label();
            this.HeaderPlace = new FeedBackSystem.HeaderPlacement();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(1019, 573);
            this.Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(112, 35);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // HeaderName
            // 
            this.HeaderName.AutoSize = true;
            this.HeaderName.Location = new System.Drawing.Point(18, 40);
            this.HeaderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.Size = new System.Drawing.Size(108, 20);
            this.HeaderName.TabIndex = 2;
            this.HeaderName.Text = "Header Name";
            // 
            // HeaderDesc
            // 
            this.HeaderDesc.AutoSize = true;
            this.HeaderDesc.Location = new System.Drawing.Point(18, 87);
            this.HeaderDesc.Name = "HeaderDesc";
            this.HeaderDesc.Size = new System.Drawing.Size(146, 20);
            this.HeaderDesc.TabIndex = 3;
            this.HeaderDesc.Text = "Header Description";
            // 
            // HeaderPlace
            // 
            this.HeaderPlace.AutoScroll = true;
            this.HeaderPlace.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HeaderPlace.Location = new System.Drawing.Point(22, 136);
            this.HeaderPlace.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.HeaderPlace.Name = "HeaderPlace";
            this.HeaderPlace.Size = new System.Drawing.Size(1109, 408);
            this.HeaderPlace.TabIndex = 0;
            // 
            // MoreInfoHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 640);
            this.ControlBox = false;
            this.Controls.Add(this.HeaderDesc);
            this.Controls.Add(this.HeaderName);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.HeaderPlace);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MoreInfoHeader";
            this.Text = "More Info...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HeaderPlacement HeaderPlace;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label HeaderName;
        private System.Windows.Forms.Label HeaderDesc;
    }
}