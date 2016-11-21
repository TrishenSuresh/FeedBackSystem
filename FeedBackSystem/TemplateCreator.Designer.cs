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
            this.ContentTable = new System.Windows.Forms.TableLayoutPanel();
            this.SectionTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddHeaderBtn = new System.Windows.Forms.Button();
            this.HeaderControls = new System.Windows.Forms.TableLayoutPanel();
            this.ChangeHeader = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddSectionBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveTemplateBtn = new System.Windows.Forms.Button();
            this.ContentTable.SuspendLayout();
            this.HeaderControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentTable
            // 
            this.ContentTable.AutoScroll = true;
            this.ContentTable.ColumnCount = 1;
            this.ContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContentTable.Controls.Add(this.SectionTable, 0, 2);
            this.ContentTable.Controls.Add(this.AddHeaderBtn, 0, 0);
            this.ContentTable.Controls.Add(this.HeaderControls, 0, 1);
            this.ContentTable.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.ContentTable.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.ContentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTable.Location = new System.Drawing.Point(0, 0);
            this.ContentTable.Name = "ContentTable";
            this.ContentTable.RowCount = 5;
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 481F));
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ContentTable.Size = new System.Drawing.Size(925, 806);
            this.ContentTable.TabIndex = 8;
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
            this.SectionTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.SectionTable.Location = new System.Drawing.Point(3, 247);
            this.SectionTable.Name = "SectionTable";
            this.SectionTable.RowCount = 1;
            this.SectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SectionTable.Size = new System.Drawing.Size(919, 475);
            this.SectionTable.TabIndex = 9;
            // 
            // AddHeaderBtn
            // 
            this.AddHeaderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddHeaderBtn.Location = new System.Drawing.Point(3, 3);
            this.AddHeaderBtn.Name = "AddHeaderBtn";
            this.AddHeaderBtn.Size = new System.Drawing.Size(919, 201);
            this.AddHeaderBtn.TabIndex = 0;
            this.AddHeaderBtn.Text = "Add Header";
            this.AddHeaderBtn.UseVisualStyleBackColor = true;
            this.AddHeaderBtn.Click += new System.EventHandler(this.AddHeaderBtn_Click);
            // 
            // HeaderControls
            // 
            this.HeaderControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderControls.ColumnCount = 2;
            this.HeaderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HeaderControls.Controls.Add(this.ChangeHeader, 1, 0);
            this.HeaderControls.Location = new System.Drawing.Point(3, 210);
            this.HeaderControls.Name = "HeaderControls";
            this.HeaderControls.RowCount = 1;
            this.HeaderControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.HeaderControls.Size = new System.Drawing.Size(919, 31);
            this.HeaderControls.TabIndex = 10;
            // 
            // ChangeHeader
            // 
            this.ChangeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeHeader.AutoSize = true;
            this.ChangeHeader.Location = new System.Drawing.Point(824, 3);
            this.ChangeHeader.Name = "ChangeHeader";
            this.ChangeHeader.Size = new System.Drawing.Size(92, 28);
            this.ChangeHeader.TabIndex = 0;
            this.ChangeHeader.Text = "Change Header";
            this.ChangeHeader.UseVisualStyleBackColor = true;
            this.ChangeHeader.Visible = false;
            this.ChangeHeader.Click += new System.EventHandler(this.AddHeaderBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.AddSectionBtn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 728);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(919, 34);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // AddSectionBtn
            // 
            this.AddSectionBtn.AutoSize = true;
            this.AddSectionBtn.Location = new System.Drawing.Point(841, 3);
            this.AddSectionBtn.Name = "AddSectionBtn";
            this.AddSectionBtn.Size = new System.Drawing.Size(75, 23);
            this.AddSectionBtn.TabIndex = 0;
            this.AddSectionBtn.Text = "Add Section";
            this.AddSectionBtn.UseVisualStyleBackColor = true;
            this.AddSectionBtn.Click += new System.EventHandler(this.AddSectionBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.SaveTemplateBtn, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 768);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(919, 35);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // SaveTemplateBtn
            // 
            this.SaveTemplateBtn.AutoSize = true;
            this.SaveTemplateBtn.Location = new System.Drawing.Point(827, 3);
            this.SaveTemplateBtn.Name = "SaveTemplateBtn";
            this.SaveTemplateBtn.Size = new System.Drawing.Size(89, 23);
            this.SaveTemplateBtn.TabIndex = 0;
            this.SaveTemplateBtn.Text = "Save Template";
            this.SaveTemplateBtn.UseVisualStyleBackColor = true;
            this.SaveTemplateBtn.Click += new System.EventHandler(this.SaveTemplateBtn_Click);
            // 
            // TemplateCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(925, 806);
            this.Controls.Add(this.ContentTable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TemplateCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Template";
            this.ContentTable.ResumeLayout(false);
            this.HeaderControls.ResumeLayout(false);
            this.HeaderControls.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContentTable;
        private System.Windows.Forms.TableLayoutPanel SectionTable;
        private System.Windows.Forms.Button AddHeaderBtn;
        private System.Windows.Forms.TableLayoutPanel HeaderControls;
        private System.Windows.Forms.Button ChangeHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddSectionBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button SaveTemplateBtn;
    }
}