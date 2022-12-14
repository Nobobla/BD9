namespace BD9.Models
{
   public class Client
    {
        public int id { get; set; }
        public string? Surname { get; set; }
        public string? Name { get; set; } // имя пользователя
        public string? Lastname { get; set; }
        public string? Sex { get; set; }
        public string? Email { get; set; }
        public int? Phone { get; set; }

        public List<Client> Clients { get; set; } = new();
    }
}
