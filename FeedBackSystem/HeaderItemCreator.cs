using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class HeaderItemCreator : Form
    {

        public List<string> ValueItem = new List<string>();
        public string Title;
        public string InputType;



        public HeaderItemCreator()
        {
            InitializeComponent();
            InputTypeList.SelectedIndex = 0;
        }


        private void InputTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputControlPanel.Controls.Clear();

            string selectedInputType = InputTypeList.Text;

            switch (selectedInputType)
            {
                case "Text":
                    InputControlPanel.Controls.Add(new HeaderCreatorControls.Text());
                    break;
                case "Date":
                    InputControlPanel.Controls.Add(new HeaderCreatorControls.Date { Dock = DockStyle.Fill });
                    break;
                case "List":
                    InputControlPanel.Controls.Add(new HeaderCreatorControls.List { Dock = DockStyle.Fill });
                    break;
                case "Query":
                    InputControlPanel.Controls.Add(new HeaderCreatorControls.Query());
                    break;
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(InputTitle.Text.Length <= 0)
                    throw new Exception("Title is empty");
                
                //would never happen
                if (InputTypeList.Text.Length <= 0)
                    throw new Exception("Make a selection");

                Title = InputTitle.Text;
                InputType = InputTypeList.Text;

                switch (InputType)
                {
                    case "Text":
                        HeaderCreatorControls.Text text = (HeaderCreatorControls.Text)InputControlPanel.Controls[0];
                        ValueItem.Add(text.GetValue());
                        break;
                    case "Date":
                        HeaderCreatorControls.Date date = (HeaderCreatorControls.Date)InputControlPanel.Controls[0];
                        ValueItem.Add(date.GetValue());
                        break;
                    case "List":
                        HeaderCreatorControls.List list = (HeaderCreatorControls.List)InputControlPanel.Controls[0];
                        ValueItem.AddRange(list.GetValue());
                        break;
                    case "Query":
                        HeaderCreatorControls.Query query = (HeaderCreatorControls.Query)InputControlPanel.Controls[0];
                        ValueItem.Add(query.GetValue());
                        break;
                }


                DialogResult = DialogResult.OK;
                Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message,@"An Error has Occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        
    }
}
