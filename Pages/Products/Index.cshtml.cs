using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using wt_lab8_8razor_postgresql_ivanov.Data;
using wt_lab8_8razor_postgresql_ivanov.Models;

namespace wt_lab8_8razor_postgresql_ivanov.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> Products { get; set; } = new();

        // Добавляем поиск (как требует лаба)
        [BindProperty(SupportsGet = true)]
        public string? Search { get; set; }

        public async Task OnGetAsync()
        {
            var query = _context.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(Search))
            {
                query = query.Where(p => p.Name.Contains(Search));
            }

            Products = await query.OrderBy(p => p.Id).ToListAsync();
        }
    }
}