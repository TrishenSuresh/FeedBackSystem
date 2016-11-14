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
            this.HeaderPlace = new FeedBackSystem.HeaderPlacement();
            this.HeaderName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(874, 350);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // HeaderPlace
            // 
            this.HeaderPlace.AutoScroll = true;
            this.HeaderPlace.Location = new System.Drawing.Point(12, 66);
            this.HeaderPlace.Name = "HeaderPlace";
            this.HeaderPlace.Size = new System.Drawing.Size(959, 265);
            this.HeaderPlace.TabIndex = 0;
            // 
            // HeaderName
            // 
            this.HeaderName.AutoSize = true;
            this.HeaderName.Location = new System.Drawing.Point(12, 26);
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.Size = new System.Drawing.Size(73, 13);
            this.HeaderName.TabIndex = 2;
            this.HeaderName.Text = "Header Name";
            // 
            // MoreInfoHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 400);
            this.ControlBox = false;
            this.Controls.Add(this.HeaderName);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.HeaderPlace);
            this.Name = "MoreInfoHeader";
            this.Text = "More Info...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HeaderPlacement HeaderPlace;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label HeaderName;
    }
}