namespace BD9.Models
{
    public class Emploee
    {
        public int id { get; set; }
        //public int? Id { get; set; }//внешний ключ для контактных данных
        //public Model? Model { get; set; }
        public ContactInform? ContactInform { get; set; }//1 к 1 с контактной информацией
        public int? JobId { get; set; }//внешний ключ для работы
        public Job? Job { get; set; }

        public int? OfficeId { get; set; }//внешний ключ для офиса
        public Office? Office { get; set; }

        public List<Order> Orders { get; set; } = new();
    }
}
