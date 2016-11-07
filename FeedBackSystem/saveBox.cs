﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class SaveBox : Form
    {
        public string headerTitle;
        public string headerDesc;

        public SaveBox()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (titleText.Text.Length > 0)
            {
                headerTitle = titleText.Text;
                headerDesc = descText.Text;
                this.DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("Title must not be empty!");
            }
        }
    }
}
