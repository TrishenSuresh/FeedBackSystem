using System.Collections.Generic;

namespace FeedBackSystem
{
    public class Header
    {
        public string HeaderId { get; set; }
        public string Title { get; set; }
        public List<HeaderItem> HeaderItems { get; set; }
        public string Desc { get; set; }

        //overriding the default empty constructor as we want to create default header items in the header upon initialization
        public Header()
        {
            //Applicant's name item
            HeaderItem applicant = new HeaderItem("Applicant:", "Query", new List<string> { "<Applicant Name>" });
            HeaderItem job = new HeaderItem("Job applied:", "Query", new List<string> { "<Applied Position>" });
            HeaderItem reviewer = new HeaderItem("Reviewer:", "Query", new List<string> { "<Reviewer Name>" });
            HeaderItem applicationType = new HeaderItem("Application Type:", "Query", new List<string> { "<Application Type>" });

            this.HeaderItems = new List<HeaderItem>();
            HeaderItems.Add(applicant);
            HeaderItems.Add(job);
            HeaderItems.Add(reviewer);
            HeaderItems.Add(applicationType);
        }

        public Header(string id, string title, string desc)
        {
            this.HeaderItems = new List<HeaderItem>();
            this.HeaderId = id;
            this.Title = title;
            this.Desc = desc;
        }

        public void addHeaderItem(HeaderItem item)
        {
            this.HeaderItems.Add(item);
        }

        public void removeHeaderItem(int index)
        {
            this.HeaderItems.RemoveAt(index);
        }

    }
}
