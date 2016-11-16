namespace FeedBackSystem
{
    partial class SelectSection
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
            this.SectionsTable = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddSections = new System.Windows.Forms.Button();
            this.SectionsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the sections";
            // 
            // SectionsTable
            // 
            this.SectionsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SectionsTable.ColumnCount = 4;
            this.SectionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SectionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SectionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SectionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SectionsTable.Controls.Add(this.label2, 0, 0);
            this.SectionsTable.Controls.Add(this.label3, 1, 0);
            this.SectionsTable.Controls.Add(this.label4, 2, 0);
            this.SectionsTable.Location = new System.Drawing.Point(16, 75);
            this.SectionsTable.Name = "SectionsTable";
            this.SectionsTable.RowCount = 2;
            this.SectionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SectionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SectionsTable.Size = new System.Drawing.Size(444, 292);
            this.SectionsTable.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Codes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddSections
            // 
            this.AddSections.AutoSize = true;
            this.AddSections.Location = new System.Drawing.Point(377, 411);
            this.AddSections.Name = "AddSections";
            this.AddSections.Size = new System.Drawing.Size(83, 23);
            this.AddSections.TabIndex = 2;
            this.AddSections.Text = "Add Selection";
            this.AddSections.UseVisualStyleBackColor = true;
            this.AddSections.Click += new System.EventHandler(this.AddSection_Click);
            // 
            // SelectSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 479);
            this.Controls.Add(this.AddSections);
            this.Controls.Add(this.SectionsTable);
            this.Controls.Add(this.label1);
            this.Name = "SelectSection";
            this.Text = "SelectSection";
            this.SectionsTable.ResumeLayout(false);
            this.SectionsTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel SectionsTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddSections;
        private System.Windows.Forms.Label label4;
    }
}