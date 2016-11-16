using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBackSystem
{
    class Feedback
    {
        public string ApplicantId;
        public string ReviewerId;
        public Header Header;
        public List<Section> Sections;

        public void AddSection(Section section)
        {
            Sections.Add(section);
        }

    }

    
}
