namespace FeedBackSystem.HeaderControls
{
    partial class List
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
            this.ListTitle = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ListTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(209, 27);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ListTitle
            // 
            this.ListTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ListTitle.AutoSize = true;
            this.ListTitle.Location = new System.Drawing.Point(3, 7);
            this.ListTitle.Name = "ListTitle";
            this.ListTitle.Size = new System.Drawing.Size(46, 13);
            this.ListTitle.TabIndex = 0;
            this.ListTitle.Text = "List Title";
            // 
            // ListBox
            // 
            this.ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(55, 3);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(151, 21);
            this.ListBox.TabIndex = 1;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "List";
            this.Size = new System.Drawing.Size(215, 33);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ListTitle;
        private System.Windows.Forms.ComboBox ListBox;
    }
}
