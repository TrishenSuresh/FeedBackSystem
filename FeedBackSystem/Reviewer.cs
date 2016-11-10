using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBackSystem
{
    static class Reviewer
    {
        private static string _reviewerName = "";

        public static string ReviewerName
        {
            get { return _reviewerName; }
            set { _reviewerName = value; }
        }
        

    }
}
