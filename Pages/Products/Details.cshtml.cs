using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_ivanov.Models;
using wt_lab5_5razor_ivanov.Data;

namespace wt_lab5_5razor_ivanov.Pages.Products
{
    public class DetailsModel : PageModel
    {
        public Product? Product { get; set; }

        public IActionResult OnGet(int id)
        {
            Product = ProductStore.Products.FirstOrDefault(x => x.Id == id);
            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}