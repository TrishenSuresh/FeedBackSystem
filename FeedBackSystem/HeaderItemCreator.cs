using System;
using System.Collections.Generic;
using System.Drawing;
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

            InputTypeHelp.Image = new Icon(SystemIcons.Question, 32, 32).ToBitmap();
        }


        private void InputTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputControlPanel.Controls.Clear();

            string selectedInputType = InputTypeList.Text;

            switch (selectedInputType)
            {
                case "Text":
                case "Label":
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
                    case "Label":
                        HeaderCreatorControls.Text label = (HeaderCreatorControls.Text)InputControlPanel.Controls[0];
                        if(label.GetValue().Length == 0)
                        {
                            throw new Exception("Label text must not be empty!");
                        }
                        ValueItem.Add(label.GetValue());
                        break;
                    case "Date":
                        HeaderCreatorControls.Date date = (HeaderCreatorControls.Date)InputControlPanel.Controls[0];
                        if (date.GetValue().Equals("<Review Date>"))
                            InputType = "Query";
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

        private void InputTypeHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input Type descriptions:\n" +
                "\tText  :  Free flow input during generating feedback. \n" +
                "\tLabel  :  Static input during header creation. \n" +
                "\tDate  :  Could be manual date or data retrieved from database. \n" +
                "\tList  :  User-defined list of items. \n" +
                "\tQuery  :  Data that will be retrieved from the database and set upon selection during generating the feedback. \n"
                , @"What input type?");
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
