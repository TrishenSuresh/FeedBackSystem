using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public class HeaderItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string InputType { get; set; }
        public string ValueChosen { get; set; }
        public List<string> ValueItem { get; set; }
        public string QueryStat { get; set; }

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
            MySql sql = new MySql();
            this.Title = title;
            this.InputType = inputType;
            this.ValueItem = new List<string>();
            //new memory allocation 
            if (inputType.Equals("Query"))
            {
                try
                {
                    
                    sql.OpenConnection();
                    DataTable dt = sql.GetDataSet(value);
                    foreach (DataRow dr in dt.Rows)
                    {
                        string name = dr["title"].ToString();
                        ValueItem.Add(name);
                    }
                }
                catch (Exception genExp)
                {
                    MessageBox.Show(genExp.Message);
                }
                finally
                {
                    sql.CloseConnection();
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
