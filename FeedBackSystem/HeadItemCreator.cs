using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class HeadItemCreator : Form
    {
        
        public HeadItemCreator()
        {
            InitializeComponent();
            textPanel.Visible = false;
            datePanel.Visible = false;
            listPanel.Visible = false;
            queryPanel.Visible = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(titleText.Text.Length != 0)
            {
                if(inputTypeList.Text.Length != 0)
                {
                    List<string> valueItem = new List<string>();
                    try
                    {
                        switch (inputTypeList.Text)
                        {
                            case "Text":
                                if (textText.Text.Length != 0)
                                {
                                    valueItem.Add(textText.Text);
                                }
                                else
                                {
                                    throw new Exception("The text is empty!");
                                }
                                break;
                            case "List":
                                if (listText.Text.Length != 0)
                                {
                                    valueItem.AddRange(new List<string>(listText.Text.Split(new string[] { "\r\n" },
                                        StringSplitOptions.RemoveEmptyEntries)));
                                }
                                else
                                {
                                    throw new Exception("The list is empty!!");
                                }
                                break;
                            case "Date":
                                if (todayRbtn.Checked)
                                {
                                    valueItem.Add("today"); //temporary
                                }
                                else
                                {
                                    if (reviewRBtn.Checked)
                                    {
                                        valueItem.Add("review");    //temporary
                                    }
                                    else
                                    {
                                        if (manualRBtn.Checked)
                                        {
                                            valueItem.Add("manual");    //temporary
                                        }
                                        else
                                        {
                                            throw new Exception("There is no selection!");
                                        }
                                    }
                                }
                                break;
                            case "Query":
                                if (queryList.Text.Length != 0)
                                {
                                    valueItem.Add(queryList.Text);
                                }
                                else
                                {
                                    throw new Exception("There is no selection!");
                                }
                                break;
                            default:        //should nvr be invoked
                                throw new Exception("Invalid selection value!");
                        }
                        HeaderItem item = new HeaderItem(titleText.Text, inputTypeList.Text, valueItem);
                        //need to return this object back to the caller
                        this.Close();
                    } catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    
                }
                else
                {
                    MessageBox.Show(@"Input type cannot be empty!");
                }
            }
            else
            {
                MessageBox.Show(@"Title cannot be empty!");
            }
        }

        private void inputTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textPanel.Visible = false;
            datePanel.Visible = false;
            listPanel.Visible = false;
            queryPanel.Visible = false;
            string selectedItem = inputTypeList.Text;

            switch (selectedItem)
            {
                case "Text":
                    textPanel.Visible = true;
                    break;
                case "List":
                    listPanel.Visible = true;
                    break;
                case "Date":
                    datePanel.Visible = true;
                    break;
                case "Query":
                    queryPanel.Visible = true;
                    break;
                default:    //should nvr be invoked
                    throw new Exception("Unknown exception");
            }
        }
    }
}
