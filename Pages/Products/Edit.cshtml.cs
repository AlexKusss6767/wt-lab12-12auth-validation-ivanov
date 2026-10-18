using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_ivanov.Models;
using wt_lab5_5razor_ivanov.Data;

namespace wt_lab5_5razor_ivanov.Pages.Products
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            var existing = ProductStore.Products.FirstOrDefault(x => x.Id == id);
            if (existing == null) return NotFound();
            
            Product = existing;
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            if (id != Product.Id) return NotFound();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var existing = ProductStore.Products.FirstOrDefault(x => x.Id == id);
            if (existing == null) return NotFound();

            existing.Name = Product.Name;
            existing.Category = Product.Category;
            existing.Price = Product.Price;
            existing.IsAvailable = Product.IsAvailable;
            existing.Description = Product.Description;

            return RedirectToPage("./Index");
        }
    }
}