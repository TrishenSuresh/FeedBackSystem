namespace FeedBackSystem
{
    partial class HeaderDisplay
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
            this.headerTitle = new System.Windows.Forms.Label();
            this.headerDgv = new System.Windows.Forms.DataGridView();
            this.addHeaderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headerDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // headerTitle
            // 
            this.headerTitle.AutoSize = true;
            this.headerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTitle.Location = new System.Drawing.Point(23, 20);
            this.headerTitle.Name = "headerTitle";
            this.headerTitle.Size = new System.Drawing.Size(116, 25);
            this.headerTitle.TabIndex = 0;
            this.headerTitle.Text = "All headers:";
            // 
            // headerDgv
            // 
            this.headerDgv.AllowUserToAddRows = false;
            this.headerDgv.AllowUserToDeleteRows = false;
            this.headerDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.headerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.headerDgv.Location = new System.Drawing.Point(28, 58);
            this.headerDgv.Name = "headerDgv";
            this.headerDgv.ReadOnly = true;
            this.headerDgv.RowTemplate.Height = 28;
            this.headerDgv.Size = new System.Drawing.Size(1180, 393);
            this.headerDgv.TabIndex = 1;
            // 
            // addHeaderBtn
            // 
            this.addHeaderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addHeaderBtn.Location = new System.Drawing.Point(1065, 467);
            this.addHeaderBtn.Name = "addHeaderBtn";
            this.addHeaderBtn.Size = new System.Drawing.Size(143, 38);
            this.addHeaderBtn.TabIndex = 2;
            this.addHeaderBtn.Text = "Add Header";
            this.addHeaderBtn.UseVisualStyleBackColor = true;
            this.addHeaderBtn.Click += new System.EventHandler(this.addHeaderBtn_Click);
            // 
            // HeaderDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addHeaderBtn);
            this.Controls.Add(this.headerDgv);
            this.Controls.Add(this.headerTitle);
            this.Name = "HeaderDisplay";
            this.Size = new System.Drawing.Size(1260, 523);
            ((System.ComponentModel.ISupportInitialize)(this.headerDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerTitle;
        private System.Windows.Forms.DataGridView headerDgv;
        private System.Windows.Forms.Button addHeaderBtn;
    }
}
