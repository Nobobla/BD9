using BD9.Models;
using Microsoft.EntityFrameworkCore;

namespace BD9.Models
{
    public class ApplicationContext : DbContext
    {
        //public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Model> Models => Set<Model>();
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
           /* Database.EnsureCreated(); */  // создаем базу данных при первом обращении
        }
    }
}
