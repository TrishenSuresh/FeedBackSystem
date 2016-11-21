using System;
using System.Collections.Generic;

namespace FeedBackSystem
{
    public class Section
    {
        public string SectionId { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public List<string> Codes { get; set; }
        public string Comment { get; set; }
        public string CodeChosen { get; set; }
        public bool IsChecked { get; set; }


        public Section()
        {
            
        }

        public Section(string title, string desc, List<string> codes)
        {
            Title = title;
            Desc = desc;
            Codes = codes;
        }

        public Section(string sectionId,string title, string desc)
        {
            SectionId = sectionId;
            Title = title;
            Desc = desc;
        }

        public void AddCode(string code)
        {
            Codes.Add(code);
        }
    }
}
