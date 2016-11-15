using System;
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
    public partial class DeleteBox : Form
    {
        public List<string> referName;
        public int deleteIndex;

        public DeleteBox()
        {
            InitializeComponent();
        }

        public DeleteBox(List<int> indexs, List<string> names)
        {
            InitializeComponent();
            IndexList.Items.Clear();
            foreach(int index in indexs)
            {
                IndexList.Items.Add(index);
            }
            referName = new List<string>();
            referName.AddRange(names);
        }

        private void IndexList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedInput = IndexList.SelectedIndex;
            ItemNameText.Text = referName[selectedInput];
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                     "Confirm Deletion",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                deleteIndex = int.Parse(IndexList.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }

            this.Close();
        }
    }
}
