using System.Collections.Generic;

namespace FeedBackSystem
{
    public class HeaderItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string InputType { get; set; }
        public string ValueChosen { get; set; }
        public List<string> ValueItem { get; set; }


        public HeaderItem() { }

        //create a header with a list of value item
        public HeaderItem(string title, string inputType, List<string> value)
        {
            this.Title = title;
            this.InputType = inputType;
            this.ValueItem = new List<string>();
            //new memory allocation 
            ValueItem.AddRange(value);
        }

        //create a header with a list of value item when the id is known (from db)
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
