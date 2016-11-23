using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FeedBackSystem.HeaderCreatorControls
{
    public partial class List : UserControl
    {
        public List()
        {
            InitializeComponent();
        }

        public List<string> GetValue()
        {
            List<string> list = new List<string>(ListBox.Lines);
            list.RemoveAll(item => item.Length == 0);

            if(list.Count == 0)
            {
                throw new Exception("The list cannot be empty!");
            }

            return list;
        }

        public void SetValue(List<String> s)
        {
            ListBox.Lines = s.ToArray();
        }
    }
}
