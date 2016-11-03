namespace FeedBackSystem.HeaderCreatorControls
{
    partial class Date
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
            this.label1 = new System.Windows.Forms.Label();
            this.TodayRadio = new System.Windows.Forms.RadioButton();
            this.Review_InterviewRadio = new System.Windows.Forms.RadioButton();
            this.ManualRadio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TodayRadio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Review_InterviewRadio, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ManualRadio, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 95);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the date type :";
            // 
            // TodayRadio
            // 
            this.TodayRadio.AutoSize = true;
            this.TodayRadio.Location = new System.Drawing.Point(3, 16);
            this.TodayRadio.Name = "TodayRadio";
            this.TodayRadio.Size = new System.Drawing.Size(88, 17);
            this.TodayRadio.TabIndex = 1;
            this.TodayRadio.TabStop = true;
            this.TodayRadio.Text = "Today\'s Date";
            this.TodayRadio.UseVisualStyleBackColor = true;
            // 
            // Review_InterviewRadio
            // 
            this.Review_InterviewRadio.AutoSize = true;
            this.Review_InterviewRadio.Location = new System.Drawing.Point(3, 39);
            this.Review_InterviewRadio.Name = "Review_InterviewRadio";
            this.Review_InterviewRadio.Size = new System.Drawing.Size(141, 17);
            this.Review_InterviewRadio.TabIndex = 2;
            this.Review_InterviewRadio.TabStop = true;
            this.Review_InterviewRadio.Text = "Review / Interview Date";
            this.Review_InterviewRadio.UseVisualStyleBackColor = true;
            // 
            // ManualRadio
            // 
            this.ManualRadio.AutoSize = true;
            this.ManualRadio.Location = new System.Drawing.Point(3, 62);
            this.ManualRadio.Name = "ManualRadio";
            this.ManualRadio.Size = new System.Drawing.Size(60, 17);
            this.ManualRadio.TabIndex = 3;
            this.ManualRadio.TabStop = true;
            this.ManualRadio.Text = "Manual";
            this.ManualRadio.UseVisualStyleBackColor = true;
            // 
            // Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Date";
            this.Size = new System.Drawing.Size(234, 101);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton TodayRadio;
        private System.Windows.Forms.RadioButton Review_InterviewRadio;
        private System.Windows.Forms.RadioButton ManualRadio;
    }
}
