using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_ivanov.Models;
using wt_lab5_5razor_ivanov.Data;

namespace wt_lab5_5razor_ivanov.Pages.Products
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Product.Id = ProductStore.Products.Any() 
                ? ProductStore.Products.Max(x => x.Id) + 1 
                : 1;
            
            ProductStore.Products.Add(Product);

            return RedirectToPage("./Index");
        }
    }
}