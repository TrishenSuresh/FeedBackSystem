namespace FeedBackSystem
{
    partial class TextBoxHeader
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderItemTitle = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.HeaderItemTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 107);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HeaderItemTitle
            // 
            this.HeaderItemTitle.AutoEllipsis = true;
            this.HeaderItemTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderItemTitle.Location = new System.Drawing.Point(3, 0);
            this.HeaderItemTitle.Name = "HeaderItemTitle";
            this.HeaderItemTitle.Size = new System.Drawing.Size(244, 107);
            this.HeaderItemTitle.TabIndex = 0;
            this.HeaderItemTitle.Text = "Header Item Title";
            this.HeaderItemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox
            // 
            this.TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox.Location = new System.Drawing.Point(253, 43);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(245, 20);
            this.TextBox.TabIndex = 1;
            // 
            // TextBoxHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TextBoxHeader";
            this.Size = new System.Drawing.Size(501, 107);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label HeaderItemTitle;
        private System.Windows.Forms.TextBox TextBox;
    }
}
