namespace FeedBackSystem
{
    partial class HeadItemCreator
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.inputTypeLabel = new System.Windows.Forms.Label();
            this.inputTypeList = new System.Windows.Forms.ComboBox();
            this.textPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textLabel = new System.Windows.Forms.Label();
            this.textText = new System.Windows.Forms.TextBox();
            this.datePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.todayRbtn = new System.Windows.Forms.RadioButton();
            this.reviewRBtn = new System.Windows.Forms.RadioButton();
            this.manualRBtn = new System.Windows.Forms.RadioButton();
            this.listPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.listLabel = new System.Windows.Forms.Label();
            this.listText = new System.Windows.Forms.TextBox();
            this.queryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryList = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.textPanel.SuspendLayout();
            this.datePanel.SuspendLayout();
            this.listPanel.SuspendLayout();
            this.queryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(222, 30);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(260, 28);
            this.titleText.Margin = new System.Windows.Forms.Padding(1);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(138, 20);
            this.titleText.TabIndex = 1;
            // 
            // inputTypeLabel
            // 
            this.inputTypeLabel.AutoSize = true;
            this.inputTypeLabel.Location = new System.Drawing.Point(194, 56);
            this.inputTypeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.inputTypeLabel.Name = "inputTypeLabel";
            this.inputTypeLabel.Size = new System.Drawing.Size(58, 13);
            this.inputTypeLabel.TabIndex = 2;
            this.inputTypeLabel.Text = "Input Type";
            // 
            // inputTypeList
            // 
            this.inputTypeList.FormattingEnabled = true;
            this.inputTypeList.Items.AddRange(new object[] {
            "Text",
            "List",
            "Date",
            "Query"});
            this.inputTypeList.Location = new System.Drawing.Point(260, 56);
            this.inputTypeList.Margin = new System.Windows.Forms.Padding(1);
            this.inputTypeList.Name = "inputTypeList";
            this.inputTypeList.Size = new System.Drawing.Size(98, 21);
            this.inputTypeList.TabIndex = 3;
            this.inputTypeList.SelectedIndexChanged += new System.EventHandler(this.inputTypeList_SelectedIndexChanged);
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.textLabel);
            this.textPanel.Controls.Add(this.textText);
            this.textPanel.Location = new System.Drawing.Point(228, 87);
            this.textPanel.Margin = new System.Windows.Forms.Padding(1);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(194, 118);
            this.textPanel.TabIndex = 4;
            this.textPanel.Visible = false;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(1, 0);
            this.textLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(31, 13);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Text:";
            // 
            // textText
            // 
            this.textText.Location = new System.Drawing.Point(34, 1);
            this.textText.Margin = new System.Windows.Forms.Padding(1);
            this.textText.Name = "textText";
            this.textText.Size = new System.Drawing.Size(146, 20);
            this.textText.TabIndex = 1;
            // 
            // datePanel
            // 
            this.datePanel.Controls.Add(this.dateLabel);
            this.datePanel.Controls.Add(this.todayRbtn);
            this.datePanel.Controls.Add(this.reviewRBtn);
            this.datePanel.Controls.Add(this.manualRBtn);
            this.datePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.datePanel.Location = new System.Drawing.Point(227, 88);
            this.datePanel.Margin = new System.Windows.Forms.Padding(1);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(194, 117);
            this.datePanel.TabIndex = 5;
            this.datePanel.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(1, 0);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(111, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Choose the date type:";
            // 
            // todayRbtn
            // 
            this.todayRbtn.AutoSize = true;
            this.todayRbtn.Location = new System.Drawing.Point(1, 14);
            this.todayRbtn.Margin = new System.Windows.Forms.Padding(1);
            this.todayRbtn.Name = "todayRbtn";
            this.todayRbtn.Size = new System.Drawing.Size(88, 17);
            this.todayRbtn.TabIndex = 1;
            this.todayRbtn.TabStop = true;
            this.todayRbtn.Text = "Today\'s Date";
            this.todayRbtn.UseVisualStyleBackColor = true;
            // 
            // reviewRBtn
            // 
            this.reviewRBtn.AutoSize = true;
            this.reviewRBtn.Location = new System.Drawing.Point(1, 33);
            this.reviewRBtn.Margin = new System.Windows.Forms.Padding(1);
            this.reviewRBtn.Name = "reviewRBtn";
            this.reviewRBtn.Size = new System.Drawing.Size(141, 17);
            this.reviewRBtn.TabIndex = 2;
            this.reviewRBtn.TabStop = true;
            this.reviewRBtn.Text = "Review / Interview Date";
            this.reviewRBtn.UseVisualStyleBackColor = true;
            // 
            // manualRBtn
            // 
            this.manualRBtn.AutoSize = true;
            this.manualRBtn.Location = new System.Drawing.Point(1, 52);
            this.manualRBtn.Margin = new System.Windows.Forms.Padding(1);
            this.manualRBtn.Name = "manualRBtn";
            this.manualRBtn.Size = new System.Drawing.Size(60, 17);
            this.manualRBtn.TabIndex = 3;
            this.manualRBtn.TabStop = true;
            this.manualRBtn.Text = "Manual";
            this.manualRBtn.UseVisualStyleBackColor = true;
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.listLabel);
            this.listPanel.Controls.Add(this.listText);
            this.listPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listPanel.Location = new System.Drawing.Point(228, 87);
            this.listPanel.Margin = new System.Windows.Forms.Padding(1);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(194, 118);
            this.listPanel.TabIndex = 6;
            this.listPanel.Visible = false;
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Location = new System.Drawing.Point(1, 0);
            this.listLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(136, 13);
            this.listLabel.TabIndex = 0;
            this.listLabel.Text = "Input the list (One line one):";
            // 
            // listText
            // 
            this.listText.Location = new System.Drawing.Point(1, 14);
            this.listText.Margin = new System.Windows.Forms.Padding(1);
            this.listText.Multiline = true;
            this.listText.Name = "listText";
            this.listText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listText.Size = new System.Drawing.Size(177, 91);
            this.listText.TabIndex = 1;
            // 
            // queryPanel
            // 
            this.queryPanel.Controls.Add(this.queryLabel);
            this.queryPanel.Controls.Add(this.queryList);
            this.queryPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.queryPanel.Location = new System.Drawing.Point(228, 88);
            this.queryPanel.Margin = new System.Windows.Forms.Padding(1);
            this.queryPanel.Name = "queryPanel";
            this.queryPanel.Size = new System.Drawing.Size(193, 117);
            this.queryPanel.TabIndex = 7;
            this.queryPanel.Visible = false;
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(1, 0);
            this.queryLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(172, 26);
            this.queryLabel.TabIndex = 0;
            this.queryLabel.Text = "Select your wanted list (that will be retrieve from the database):";
            // 
            // queryList
            // 
            this.queryList.FormattingEnabled = true;
            this.queryList.Items.AddRange(new object[] {
            "Applicant - Name",
            "Applicant - Email",
            "Application Status",
            "Application Type",
            "Positions"});
            this.queryList.Location = new System.Drawing.Point(1, 27);
            this.queryList.Margin = new System.Windows.Forms.Padding(1);
            this.queryList.Name = "queryList";
            this.queryList.Size = new System.Drawing.Size(137, 21);
            this.queryList.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(373, 224);
            this.addBtn.Margin = new System.Windows.Forms.Padding(1);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(49, 25);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // HeadItemCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 376);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.datePanel);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.queryPanel);
            this.Controls.Add(this.textPanel);
            this.Controls.Add(this.inputTypeList);
            this.Controls.Add(this.inputTypeLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "HeadItemCreator";
            this.Text = "HeadItemCreator";
            this.textPanel.ResumeLayout(false);
            this.textPanel.PerformLayout();
            this.datePanel.ResumeLayout(false);
            this.datePanel.PerformLayout();
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            this.queryPanel.ResumeLayout(false);
            this.queryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Label inputTypeLabel;
        private System.Windows.Forms.ComboBox inputTypeList;
        private System.Windows.Forms.FlowLayoutPanel textPanel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.FlowLayoutPanel datePanel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.RadioButton todayRbtn;
        private System.Windows.Forms.RadioButton reviewRBtn;
        private System.Windows.Forms.RadioButton manualRBtn;
        private System.Windows.Forms.FlowLayoutPanel listPanel;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.TextBox listText;
        private System.Windows.Forms.FlowLayoutPanel queryPanel;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.ComboBox queryList;
        private System.Windows.Forms.TextBox textText;
        private System.Windows.Forms.Button addBtn;
    }
}