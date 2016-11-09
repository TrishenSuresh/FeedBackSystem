using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBackSystem
{
    class Header
    {
        public string HeaderID { get; set; }
        public string Title { get; set; }
        public List<HeaderItem> HeaderItems { get; set; }
        public string Desc { get; set; }

        //overriding the default empty constructor as we want to create default header items in the header upon initialization
        public Header()
        {
            //Applicant's name item
            HeaderItem applicant = new HeaderItem("Applicant: ", "Query", "SELECT CONCAT(TRIM(firstname),' ',TRIM(lastname)) as title FROM applicant");
            HeaderItem job = new HeaderItem("Job applied: ", "Query", "SELECT name as title FROM positions");
            HeaderItem reviewer = new HeaderItem("Reviewer: ", "Query", "SELECT CONCAT(TRIM(firstname),' ',TRIM(lastname)) as title FROM reviewer");
            HeaderItem applicationType = new HeaderItem("Type: ", "Query", "SELECT name as title from applicationtype");

            this.HeaderItems = new List<HeaderItem>();
            HeaderItems.Add(applicant);
            HeaderItems.Add(job);
            HeaderItems.Add(reviewer);
            HeaderItems.Add(applicationType);
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
