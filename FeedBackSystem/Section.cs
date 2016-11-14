using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBackSystem
{
    public class Section
    {
        public string SectionId { get; set; }
        public string Title { get; set; }
        public List<string> Codes { get; set; }
        public string Comment { get; set; }
        

    }
}
