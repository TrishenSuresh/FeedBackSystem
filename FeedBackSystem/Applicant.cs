namespace FeedBackSystem
{
    class Applicant
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] Pdf { get; set; }
        public string ApplyType { get; set; }
        
        public Applicant(string id, string name, string email, byte[] pdf, string type)
        {
            Id = id;
            Name = name;
            Email = email;
            Pdf = pdf;
            ApplyType = type;
        }

    }
}
