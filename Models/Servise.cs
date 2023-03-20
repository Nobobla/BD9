namespace BD9.Models
{
    public class Servise
    {
        public int id { get; set; }
        public string? ServiseName { get; set; }
        public List<ServiceModel> serviceModels { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
        public decimal Price { get; set; }
    }
}
