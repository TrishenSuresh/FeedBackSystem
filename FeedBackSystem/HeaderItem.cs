using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public class HeaderItem
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
        public string QueryStat;

        public HeaderItem() { }

        public HeaderItem(string title, string inputType, List<string> value)
        {
            this.Title = title;
            this.InputType = inputType;
            this.ValueItem = new List<string>();
            //new memory allocation 
            ValueItem.AddRange(value);
        }

        public HeaderItem(string title, string inputType, string value)
        {
            this.Title = title;
            this.InputType = inputType;
            this.ValueItem = new List<string>();
            //new memory allocation 
            if (inputType.Equals("Query"))
            {
                try
                {
                    MySql sql = new MySql();
                    DataTable dt = sql.getDataSet(value);
                    foreach (DataRow dr in dt.Rows)
                    {
                        string name;
                        name = dr["title"].ToString();
                        ValueItem.Add(name);
                    }
                } catch (Exception genExp)
                {
                    MessageBox.Show(genExp.Message);
                }
                QueryStat = value;
            }
            else
            {
                ValueItem.Add(value);
            }
        }
    }
}
