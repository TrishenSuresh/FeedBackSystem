using System;

namespace FeedBackSystem
{
    class Applicant
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] Pdf { get; set; }
        public string ApplyType { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
        
        public Applicant(string id, string name, string email, byte[] pdf, string type, string status, string date)
        {
            Id = id;
            Name = name;
            Email = email;
            Pdf = pdf;
            ApplyType = type;
            Status = status;
            var dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Convert.ToInt32(date)).ToLocalTime();
            Date = dt.ToString("dd-MM-yyyy");
        }

    }
}
