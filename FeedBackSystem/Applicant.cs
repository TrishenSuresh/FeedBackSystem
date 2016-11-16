namespace FeedBackSystem
{
    class Applicant
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] Pdf { get; set; }


      

        public Applicant(string id, string name, string email, byte[] pdf)
        {
            Id = id;
            Name = name;
            Email = email;
            Pdf = pdf;
        }

    }
}
