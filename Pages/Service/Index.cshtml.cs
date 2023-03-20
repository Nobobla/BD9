using BD9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BD9.Pages.Service
{
    public class IndexModel : PageModel
    {
        ApplicationContext context;
        public List<Servise> Servises { get; private set; } = new();
        public IndexModel(ApplicationContext db)
        {
            context = db;
        }
        public void OnGet()
        {
            //Servises = context.Servises.AsNoTracking().ToList();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            //var user = await context.Servises.FindAsync(id);

            //if (user != null)
            //{
            //    //context.Servises.Remove(user);
            //    await context.SaveChangesAsync();
            //}

            return RedirectToPage();
        }
    }
}