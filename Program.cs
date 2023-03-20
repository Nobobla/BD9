using BD9.Models;
using Microsoft.EntityFrameworkCore;   // пространство имен класса ApplicationContext

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);//для DateTime
var builder = WebApplication.CreateBuilder(args);

// получаем строку подключения из файла конфигурации

// добавляем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Postgres"));
});
builder.Services.AddRazorPages();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;


    var db = serviceProvider.GetRequiredService<ApplicationContext>();
    await db.Database.EnsureDeletedAsync();//обнуление бд
    await db.Database.EnsureCreatedAsync();//создает базу данных
    await ApplicationContextSeed.InitializeDb(db);//заполнение базы данных

}
app.Run();