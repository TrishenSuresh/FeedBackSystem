using System;
using System.Windows.Forms;
using FeedBackSystem.HeaderCreatorControls;

namespace FeedBackSystem
{
    public partial class HeaderCreator : Form
    {

       

        public HeaderCreator()
        {
            InitializeComponent();
        }


        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            using (HeaderItemCreator creator = new HeaderItemCreator())
            {
                var result = creator.ShowDialog();

                if (result == DialogResult.OK)
                {
                    
                    HeaderItem item = new HeaderItem(creator.Title,creator.InputType,creator.ValueItem);

                    
                    switch (creator.InputType)
                    {
                        case "Text":
                            HeaderTab.AddItem(new HeaderControls.Text(item.Title,item.ValueItem[0]));
                            break;
                        case "List":
                            HeaderTab.AddItem(new HeaderControls.List(item.Title,item.ValueItem));
                            break;
                        

                    }
                    
                    
                   
                   
                }
            }
           
        }
    }
}
