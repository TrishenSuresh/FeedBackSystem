using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FeedBackSystem
{
    class HeaderItem
    {
        //private string id;
        //private string title;
        //private string inputType;
        //private string valueChosen;
        //private List<string> valueItems;

        public string Id { get; private set; }
        public string Title { get; private set; }
        public string InputType { get; private set; }
        public string ValueChosen { get; private set; }
        public List<string> ValueItem { get; private set; }

        public HeaderItem() { }

        public HeaderItem(string title, string inputType, List<string> value)
        {
            this.Title = title;
            this.InputType = inputType;
            this.ValueItem = new List<string>();
            //new memory allocation 
            ValueItem.AddRange(value);
        }

        public FlowLayoutPanel showItem()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();

            Label label = new Label();
            label.Text = Title;

            Label text = new Label();
            text.Text = ValueItem.ToString();
            
            try
            {
                panel.Controls.Add(label);
                panel.Controls.Add(text);
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Exception: " + e.Message);
            }
            return panel;
        }

        
    }
}
