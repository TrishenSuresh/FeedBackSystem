using System;
using System.Windows.Forms;

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

            String selectedItemType = ItemTypeList.Text;

            if (selectedItemType == null) return;

            switch (selectedItemType)
            {
                case "Text":
                    HeaderTab.AddItem(new TextBoxHeader());
                    break;
                case "List":
                    ListHeaderInput listInput = new ListHeaderInput();
                    using (listInput)
                    {
                        listInput.ShowDialog();
                        string[] lists = listInput.ReturnList();
                        string listName = listInput.ReturnListName();

                        if (listName == null) throw new ArgumentNullException(nameof(listName));

                        if (lists.Length != 0)
                        {
                            ListHeader idontknow = new ListHeader();

                        }

                    }

                    break;
            }
        }
    }
}
