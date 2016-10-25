namespace FeedBackSystem
{
    class Applicant
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] Pdf { get; set; }


      

        public Applicant(string name, string email, byte[] pdf)
        {
            Name = name;
            Email = email;
            Pdf = pdf;
        }

    }
}
