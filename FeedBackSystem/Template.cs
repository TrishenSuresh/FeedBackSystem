using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBackSystem
{
    class Template
    {
        public string Id;
        public string Title;
        public string Desc;
        public string Author;
        public Header Header;
        public List<Section> Sections = new List<Section>();
    }
}
