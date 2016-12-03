namespace FeedBackSystem
{
    partial class HeaderItemDisplay
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
            this.components = new System.ComponentModel.Container();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.ItemDVG = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueChosenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HeaderTitleText = new System.Windows.Forms.TextBox();
            this.HeaderDescText = new System.Windows.Forms.TextBox();
            this.SaveHeader = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveUp
            // 
            this.MoveUp.AutoSize = true;
            this.MoveUp.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveUp.Location = new System.Drawing.Point(1036, 138);
            this.MoveUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(112, 37);
            this.MoveUp.TabIndex = 0;
            this.MoveUp.Text = "▲";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.AutoSize = true;
            this.MoveDown.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveDown.Location = new System.Drawing.Point(1035, 183);
            this.MoveDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(112, 37);
            this.MoveDown.TabIndex = 1;
            this.MoveDown.Text = "▼";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // ItemDVG
            // 
            this.ItemDVG.AllowUserToAddRows = false;
            this.ItemDVG.AllowUserToDeleteRows = false;
            this.ItemDVG.AllowUserToResizeColumns = false;
            this.ItemDVG.AllowUserToResizeRows = false;
            this.ItemDVG.AutoGenerateColumns = false;
            this.ItemDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDVG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.inputTypeDataGridViewTextBoxColumn,
            this.valueChosenDataGridViewTextBoxColumn,
            this.Value});
            this.ItemDVG.DataSource = this.headerItemBindingSource;
            this.ItemDVG.Location = new System.Drawing.Point(130, 75);
            this.ItemDVG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemDVG.Name = "ItemDVG";
            this.ItemDVG.ReadOnly = true;
            this.ItemDVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemDVG.Size = new System.Drawing.Size(896, 557);
            this.ItemDVG.TabIndex = 2;
            this.ItemDVG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDVG_CellClick);
            this.ItemDVG.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ItemDVG_DataBindingComplete);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inputTypeDataGridViewTextBoxColumn
            // 
            this.inputTypeDataGridViewTextBoxColumn.DataPropertyName = "InputType";
            this.inputTypeDataGridViewTextBoxColumn.HeaderText = "InputType";
            this.inputTypeDataGridViewTextBoxColumn.Name = "inputTypeDataGridViewTextBoxColumn";
            this.inputTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueChosenDataGridViewTextBoxColumn
            // 
            this.valueChosenDataGridViewTextBoxColumn.DataPropertyName = "ValueChosen";
            this.valueChosenDataGridViewTextBoxColumn.HeaderText = "ValueChosen";
            this.valueChosenDataGridViewTextBoxColumn.Name = "valueChosenDataGridViewTextBoxColumn";
            this.valueChosenDataGridViewTextBoxColumn.ReadOnly = true;
            this.valueChosenDataGridViewTextBoxColumn.Visible = false;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // headerItemBindingSource
            // 
            this.headerItemBindingSource.DataSource = typeof(FeedBackSystem.HeaderItem);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(1035, 318);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(112, 35);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Header Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Header Description:";
            // 
            // HeaderTitleText
            // 
            this.HeaderTitleText.Location = new System.Drawing.Point(130, 15);
            this.HeaderTitleText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeaderTitleText.Name = "HeaderTitleText";
            this.HeaderTitleText.Size = new System.Drawing.Size(214, 26);
            this.HeaderTitleText.TabIndex = 11;
            // 
            // HeaderDescText
            // 
            this.HeaderDescText.Location = new System.Drawing.Point(566, 15);
            this.HeaderDescText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeaderDescText.Multiline = true;
            this.HeaderDescText.Name = "HeaderDescText";
            this.HeaderDescText.Size = new System.Drawing.Size(388, 29);
            this.HeaderDescText.TabIndex = 12;
            // 
            // SaveHeader
            // 
            this.SaveHeader.AutoSize = true;
            this.SaveHeader.Location = new System.Drawing.Point(948, 642);
            this.SaveHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveHeader.Name = "SaveHeader";
            this.SaveHeader.Size = new System.Drawing.Size(142, 37);
            this.SaveHeader.TabIndex = 15;
            this.SaveHeader.Text = "Save Header";
            this.SaveHeader.UseVisualStyleBackColor = true;
            this.SaveHeader.Click += new System.EventHandler(this.SaveHeader_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(1035, 229);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(112, 35);
            this.Addbtn.TabIndex = 16;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(1036, 274);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(112, 35);
            this.EditBtn.TabIndex = 17;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(799, 642);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(142, 37);
            this.CancelBtn.TabIndex = 18;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // HeaderItemDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 700);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.SaveHeader);
            this.Controls.Add(this.HeaderDescText);
            this.Controls.Add(this.HeaderTitleText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ItemDVG);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.MoveUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "HeaderItemDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Header";
            ((System.ComponentModel.ISupportInitialize)(this.ItemDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.DataGridView ItemDVG;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.BindingSource headerItemBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HeaderTitleText;
        private System.Windows.Forms.TextBox HeaderDescText;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueChosenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Button SaveHeader;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}