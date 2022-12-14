namespace BD9.Models
{
    public class ContactInform
    {
        public int id { get; set; }

        public int EmploeeId { get; set; }//для 1 к 1 связь
        public Emploee? Emploee { get; set; } 
        
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public int? Phone { get; set; }
        public int? PSeries { get; set; }
        public int? PNumber { get; set; }
        public int? Snils { get; set; }
        public string? Adress { get; set; }
        public DateTime? Date { get; set; }

    }
}
