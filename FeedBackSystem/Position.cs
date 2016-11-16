using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBackSystem
{
    public class Position
    {
        public string _positionId { get; set; }
        public string _positionName { get; set; }
        public string _positionDesc { get; set; }
        public string _positionDept { get; set; }
        public string _minQualification { get; set; }

        public Position(string positionId, string positionName, string positionDesc, string positionDept,
            string minQualification)
        {
            _positionId = positionId;
            _positionName = positionName;
            _positionDesc = positionDesc;
            _positionDept = positionDept;
            _minQualification = minQualification;
        }
    }
}   
