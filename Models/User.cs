using System.ComponentModel.DataAnnotations;

namespace wt_lab8_8razor_postgresql_ivanov.Models; // Оставляем старый неймспейс!

public class User
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Введите логин")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Логин должен содержать от 3 до 50 символов")]
    public string Login { get; set; } = string.Empty;

    [Required(ErrorMessage = "Введите пароль")]
    [StringLength(100, MinimumLength = 4, ErrorMessage = "Пароль должен содержать не менее 4 символов")]
    public string Password { get; set; } = string.Empty;
}