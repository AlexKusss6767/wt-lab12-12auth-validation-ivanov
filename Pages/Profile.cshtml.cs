using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace wt_lab8_8razor_postgresql_ivanov.Pages
{
    public class ProfileModel : PageModel
    {
        public string? UserLogin { get; set; }

        public IActionResult OnGet()
        {
            // Проверяем, есть ли логин в сессии
            UserLogin = HttpContext.Session.GetString("UserLogin");

            // Если нет — отправляем на страницу входа
            if (UserLogin == null)
            {
                return RedirectToPage("/Login");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            // Выход: очищаем сессию
            HttpContext.Session.Clear();
            return RedirectToPage("/Login");
        }
    }
}