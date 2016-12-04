namespace FeedBackSystem
{
    partial class SectionSelection
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
            this.components = new System.ComponentModel.Container();
            this.AvailableSectionDGV = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Codes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedSectionDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableSectionDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedSectionDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AvailableSectionDGV
            // 
            this.AvailableSectionDGV.AutoGenerateColumns = false;
            this.AvailableSectionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableSectionDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.descDataGridViewTextBoxColumn,
            this.Codes});
            this.AvailableSectionDGV.DataSource = this.sectionBindingSource;
            this.AvailableSectionDGV.Location = new System.Drawing.Point(3, 31);
            this.AvailableSectionDGV.Name = "AvailableSectionDGV";
            this.AvailableSectionDGV.ReadOnly = true;
            this.AvailableSectionDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AvailableSectionDGV.Size = new System.Drawing.Size(605, 212);
            this.AvailableSectionDGV.TabIndex = 0;
            this.AvailableSectionDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AvailableSectionDGV_CellClick);
            this.AvailableSectionDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AvailableSectionDGV_DataBindingComplete);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(614, 102);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "►";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Location = new System.Drawing.Point(614, 144);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "◄";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Available Sections";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selected Sections";
            // 
            // Codes
            // 
            this.Codes.HeaderText = "Codes";
            this.Codes.Name = "Codes";
            this.Codes.ReadOnly = true;
            // 
            // SelectedSectionDGV
            // 
            this.SelectedSectionDGV.AutoGenerateColumns = false;
            this.SelectedSectionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedSectionDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.SelectedSectionDGV.DataSource = this.sectionBindingSource;
            this.SelectedSectionDGV.Location = new System.Drawing.Point(695, 31);
            this.SelectedSectionDGV.Name = "SelectedSectionDGV";
            this.SelectedSectionDGV.ReadOnly = true;
            this.SelectedSectionDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectedSectionDGV.Size = new System.Drawing.Size(605, 212);
            this.SelectedSectionDGV.TabIndex = 6;
            this.SelectedSectionDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectedSectionDGV_CellClick);
            this.SelectedSectionDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.SelectedSectionDGV_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Codes";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Desc";
            this.dataGridViewTextBoxColumn2.HeaderText = "Desc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataSource = typeof(FeedBackSystem.Section);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descDataGridViewTextBoxColumn
            // 
            this.descDataGridViewTextBoxColumn.DataPropertyName = "Desc";
            this.descDataGridViewTextBoxColumn.HeaderText = "Desc";
            this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            this.descDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SectionSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedSectionDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AvailableSectionDGV);
            this.Name = "SectionSelection";
            this.Size = new System.Drawing.Size(1305, 251);
            ((System.ComponentModel.ISupportInitialize)(this.AvailableSectionDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedSectionDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AvailableSectionDGV;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codes;
        private System.Windows.Forms.DataGridView SelectedSectionDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
