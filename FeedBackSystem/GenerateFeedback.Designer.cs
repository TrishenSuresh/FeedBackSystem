namespace FeedBackSystem
{
    partial class GenerateFeedback
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
            this.PositionList = new System.Windows.Forms.ListBox();
            this.ApplicantList = new System.Windows.Forms.ListBox();
            this.PDFPanel = new System.Windows.Forms.Panel();
            this.PDFDisplay = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.SaveFeedbackBtn = new System.Windows.Forms.Button();
            this.AddSectionBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ContentTable = new System.Windows.Forms.TableLayoutPanel();
            this.SectionTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddHeaderBtn = new System.Windows.Forms.Button();
            this.HeaderControls = new System.Windows.Forms.TableLayoutPanel();
            this.ChangeHeader = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.PDFPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.ContentTable.SuspendLayout();
            this.HeaderControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.36977F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.565916F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.PositionList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ApplicantList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PDFPanel, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.ContentTable, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.80769F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.499999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 822);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PositionList
            // 
            this.PositionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionList.FormattingEnabled = true;
            this.PositionList.Location = new System.Drawing.Point(3, 16);
            this.PositionList.Name = "PositionList";
            this.tableLayoutPanel1.SetRowSpan(this.PositionList, 8);
            this.PositionList.Size = new System.Drawing.Size(118, 715);
            this.PositionList.TabIndex = 1;
            this.PositionList.SelectedIndexChanged += new System.EventHandler(this.PositionList_SelectedIndexChanged);
            // 
            // ApplicantList
            // 
            this.ApplicantList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplicantList.FormattingEnabled = true;
            this.ApplicantList.Location = new System.Drawing.Point(127, 16);
            this.ApplicantList.Name = "ApplicantList";
            this.tableLayoutPanel1.SetRowSpan(this.ApplicantList, 8);
            this.ApplicantList.Size = new System.Drawing.Size(123, 715);
            this.ApplicantList.TabIndex = 2;
            this.ApplicantList.SelectedIndexChanged += new System.EventHandler(this.ApplicantList_SelectedIndexChanged);
            // 
            // PDFPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PDFPanel, 3);
            this.PDFPanel.Controls.Add(this.PDFDisplay);
            this.PDFPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDFPanel.Location = new System.Drawing.Point(871, 16);
            this.PDFPanel.Name = "PDFPanel";
            this.tableLayoutPanel1.SetRowSpan(this.PDFPanel, 8);
            this.PDFPanel.Size = new System.Drawing.Size(370, 715);
            this.PDFPanel.TabIndex = 5;
            // 
            // PDFDisplay
            // 
            this.PDFDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDFDisplay.Location = new System.Drawing.Point(0, 0);
            this.PDFDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.PDFDisplay.Name = "PDFDisplay";
            this.PDFDisplay.Size = new System.Drawing.Size(370, 715);
            this.PDFDisplay.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 5);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.button5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.SaveFeedbackBtn, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.AddSectionBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(256, 737);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(609, 82);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 28);
            this.button5.TabIndex = 1;
            this.button5.Text = "Save Template";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // SaveFeedbackBtn
            // 
            this.SaveFeedbackBtn.Location = new System.Drawing.Point(449, 37);
            this.SaveFeedbackBtn.Name = "SaveFeedbackBtn";
            this.SaveFeedbackBtn.Size = new System.Drawing.Size(157, 28);
            this.SaveFeedbackBtn.TabIndex = 0;
            this.SaveFeedbackBtn.Text = "Save Feedback";
            this.SaveFeedbackBtn.UseVisualStyleBackColor = true;
            this.SaveFeedbackBtn.Click += new System.EventHandler(this.SaveFeedbackBtn_Click);
            // 
            // AddSectionBtn
            // 
            this.AddSectionBtn.Location = new System.Drawing.Point(449, 3);
            this.AddSectionBtn.Name = "AddSectionBtn";
            this.AddSectionBtn.Size = new System.Drawing.Size(157, 28);
            this.AddSectionBtn.TabIndex = 0;
            this.AddSectionBtn.Text = "Add Section";
            this.AddSectionBtn.UseVisualStyleBackColor = true;
            this.AddSectionBtn.Click += new System.EventHandler(this.AddSectionBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Load Template";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ContentTable
            // 
            this.ContentTable.AutoScroll = true;
            this.ContentTable.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.ContentTable, 5);
            this.ContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContentTable.Controls.Add(this.SectionTable, 0, 2);
            this.ContentTable.Controls.Add(this.AddHeaderBtn, 0, 0);
            this.ContentTable.Controls.Add(this.HeaderControls, 0, 1);
            this.ContentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTable.Location = new System.Drawing.Point(256, 16);
            this.ContentTable.Name = "ContentTable";
            this.ContentTable.RowCount = 3;
            this.tableLayoutPanel1.SetRowSpan(this.ContentTable, 8);
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 481F));
            this.ContentTable.Size = new System.Drawing.Size(609, 715);
            this.ContentTable.TabIndex = 7;
            // 
            // SectionTable
            // 
            this.SectionTable.AutoScroll = true;
            this.SectionTable.AutoScrollMinSize = new System.Drawing.Size(5, 0);
            this.SectionTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SectionTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SectionTable.ColumnCount = 2;
            this.SectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SectionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionTable.Location = new System.Drawing.Point(3, 247);
            this.SectionTable.Name = "SectionTable";
            this.SectionTable.RowCount = 1;
            this.SectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SectionTable.Size = new System.Drawing.Size(603, 475);
            this.SectionTable.TabIndex = 9;
            // 
            // AddHeaderBtn
            // 
            this.AddHeaderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddHeaderBtn.Location = new System.Drawing.Point(3, 3);
            this.AddHeaderBtn.Name = "AddHeaderBtn";
            this.AddHeaderBtn.Size = new System.Drawing.Size(603, 201);
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
            this.HeaderControls.Size = new System.Drawing.Size(603, 31);
            this.HeaderControls.TabIndex = 10;
            // 
            // ChangeHeader
            // 
            this.ChangeHeader.AutoSize = true;
            this.ChangeHeader.Location = new System.Drawing.Point(508, 3);
            this.ChangeHeader.Name = "ChangeHeader";
            this.ChangeHeader.Size = new System.Drawing.Size(92, 23);
            this.ChangeHeader.TabIndex = 0;
            this.ChangeHeader.Text = "Change Header";
            this.ChangeHeader.UseVisualStyleBackColor = true;
            this.ChangeHeader.Visible = false;
            this.ChangeHeader.Click += new System.EventHandler(this.ChangeHeader_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Positions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Applicants";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GenerateFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GenerateFeedback";
            this.Size = new System.Drawing.Size(1244, 822);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.PDFPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ContentTable.ResumeLayout(false);
            this.HeaderControls.ResumeLayout(false);
            this.HeaderControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox PositionList;
        private System.Windows.Forms.ListBox ApplicantList;
        private System.Windows.Forms.Panel PDFPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button SaveFeedbackBtn;
        private System.Windows.Forms.Button AddSectionBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.WebBrowser PDFDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel ContentTable;
        private System.Windows.Forms.TableLayoutPanel SectionTable;
        private System.Windows.Forms.TableLayoutPanel HeaderControls;
        private System.Windows.Forms.Button ChangeHeader;
        private System.Windows.Forms.Button AddHeaderBtn;
    }
}
