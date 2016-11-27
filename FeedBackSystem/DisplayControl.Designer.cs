namespace FeedBackSystem
{
    partial class DisplayControl
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.RowTitleLabel = new System.Windows.Forms.Label();
            this.RowTitleText = new System.Windows.Forms.TextBox();
            this.RowDescLabel = new System.Windows.Forms.Label();
            this.RowDescText = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(22, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleLabel.Size = new System.Drawing.Size(73, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Default";
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.Location = new System.Drawing.Point(26, 62);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RowTemplate.Height = 28;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(1754, 342);
            this.Dgv.TabIndex = 1;
            this.Dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(1588, 442);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(190, 38);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.Location = new System.Drawing.Point(1194, 442);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(190, 38);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.Location = new System.Drawing.Point(1391, 442);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(190, 38);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // RowTitleLabel
            // 
            this.RowTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RowTitleLabel.AutoSize = true;
            this.RowTitleLabel.Location = new System.Drawing.Point(27, 442);
            this.RowTitleLabel.Name = "RowTitleLabel";
            this.RowTitleLabel.Size = new System.Drawing.Size(50, 20);
            this.RowTitleLabel.TabIndex = 5;
            this.RowTitleLabel.Text = "Title : ";
            // 
            // RowTitleText
            // 
            this.RowTitleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RowTitleText.Location = new System.Drawing.Point(84, 442);
            this.RowTitleText.Name = "RowTitleText";
            this.RowTitleText.Size = new System.Drawing.Size(224, 26);
            this.RowTitleText.TabIndex = 6;
            this.RowTitleText.TextChanged += new System.EventHandler(this.RowTitleText_TextChanged);
            // 
            // RowDescLabel
            // 
            this.RowDescLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RowDescLabel.AutoSize = true;
            this.RowDescLabel.Location = new System.Drawing.Point(328, 442);
            this.RowDescLabel.Name = "RowDescLabel";
            this.RowDescLabel.Size = new System.Drawing.Size(93, 20);
            this.RowDescLabel.TabIndex = 7;
            this.RowDescLabel.Text = "Desription : ";
            // 
            // RowDescText
            // 
            this.RowDescText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RowDescText.Location = new System.Drawing.Point(428, 442);
            this.RowDescText.Multiline = true;
            this.RowDescText.Name = "RowDescText";
            this.RowDescText.Size = new System.Drawing.Size(345, 51);
            this.RowDescText.TabIndex = 8;
            this.RowDescText.TextChanged += new System.EventHandler(this.RowDescText_TextChanged);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateBtn.Location = new System.Drawing.Point(998, 442);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(190, 37);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.RowDescText);
            this.Controls.Add(this.RowDescLabel);
            this.Controls.Add(this.RowTitleText);
            this.Controls.Add(this.RowTitleLabel);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.TitleLabel);
            this.Name = "DisplayControl";
            this.Size = new System.Drawing.Size(1823, 520);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label RowTitleLabel;
        private System.Windows.Forms.TextBox RowTitleText;
        private System.Windows.Forms.Label RowDescLabel;
        private System.Windows.Forms.TextBox RowDescText;
        private System.Windows.Forms.Button UpdateBtn;
    }
}
