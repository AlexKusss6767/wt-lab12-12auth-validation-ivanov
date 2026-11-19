using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using wt_lab8_8razor_postgresql_ivanov.Data;
using wt_lab8_8razor_postgresql_ivanov.Models;

namespace wt_lab8_8razor_postgresql_ivanov.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }

        public Product? Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (Product == null) return NotFound();

            return Page();
        }
    }
}