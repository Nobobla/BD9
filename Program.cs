using BD9.Models;
using Microsoft.EntityFrameworkCore;   // ������������ ���� ������ ApplicationContext

var builder = WebApplication.CreateBuilder(args);

// �������� ������ ����������� �� ����� ������������

// ��������� �������� ApplicationContext � �������� ������� � ����������
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
    await db.Database.EnsureDeletedAsync();
    await db.Database.EnsureCreatedAsync();


}
app.Run();