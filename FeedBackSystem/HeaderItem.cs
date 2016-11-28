using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http.Headers;
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


        public HeaderItem()
        {
            Id = "";
            Title = "";
            InputType = "";
            ValueChosen = "";
            ValueItem = new List<string>();
        }

        //create a header with a list of value item -> List
        public HeaderItem(string title, string inputType, List<string> value)
        {
            this.Title = title;
            this.InputType = inputType;
            this.ValueItem = new List<string>();
            //new memory allocation 
            ValueItem.AddRange(value);
        }

        public HeaderItem(string id, string title, string inputType, List<string> value)
        {
            this.Id = id;
            this.Title = title;
            this.InputType = inputType;
            this.ValueItem = new List<string>();
            //new memory allocation 
            ValueItem.AddRange(value);
        }
    }
}
