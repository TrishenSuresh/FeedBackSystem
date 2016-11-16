using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBackSystem
{
    class Feedback
    {
        public Applicant Applicant;
        public Position Position;
        public string ReviewerId;
        public Header Header;
        public List<Section> Sections = new List<Section>();

        public void AddSection(Section section)
        {
            Sections.Add(section);
        }

        public void RemoveSection(int index)
        {
            Sections.RemoveAt(index);
        }

    }

    
}
