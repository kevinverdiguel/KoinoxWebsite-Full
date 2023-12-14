namespace WebApplication1.Models
{
    public class Form
    {
        public Guid id { get; set; }

        public string name { get; set; }

        public string correo { get; set; }

        public string mensaje { get; set; }
    }

    public class EmailMessage
    {
        public List<Form> ToAddresses { get; set; } = new List<Form>();
        public List<Form> FromAddresses { get; set; } = new List<Form>();
        public string Subject { get; set; }
        public string Content { get; set; }
    }

}
