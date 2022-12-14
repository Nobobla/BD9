namespace BD9.Models
{
    public class Servise
    {
        public int id { get; set; }
        public string? ServiseName { get; set; }
        public int? ModelId { get; set; }//внешний ключ
        public Model? Model { get; set; }
        public int? Price { get; set; }
        public List<Order> Orders { get; set; } = new();
    }
}
