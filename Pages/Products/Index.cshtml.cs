using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_ivanov.Models;
using wt_lab5_5razor_ivanov.Data;

namespace wt_lab5_5razor_ivanov.Pages.Products
{
    public class IndexModel : PageModel
    {
        public List<Product> Products { get; set; } = new();

        public void OnGet()
        {
            Products = ProductStore.Products;
        }
    }
}