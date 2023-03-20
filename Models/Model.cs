namespace BD9.Models
{
    public class Model
    {
        public int id { get; set; }
        public string? Manufacture { get; set; }
        public string? Model_name { get; set; }
        public List<ServiceModel> serviceModels { get; set; } = new();

    }
}
