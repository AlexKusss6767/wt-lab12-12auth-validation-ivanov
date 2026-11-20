using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using wt_lab8_8razor_postgresql_ivanov.Data;

namespace wt_lab8_8razor_postgresql_ivanov.Pages
{
    public class LoginModel : PageModel
    {
        private readonly AppDbContext _context;

        public LoginModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string Login { get; set; } = string.Empty;

        [BindProperty]
        public string Password { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Ищем пользователя в базе данных
            var user = await _context.Users
                .FirstOrDefaultAsync(x => x.Login == Login && x.Password == Password);

            if (user == null)
            {
                ModelState.AddModelError("", "Неверный логин или пароль.");
                return Page();
            }

            // Сохраняем логин в сессию (авторизуем)
            HttpContext.Session.SetString("UserLogin", user.Login);

            return RedirectToPage("/Profile");
        }
    }
}