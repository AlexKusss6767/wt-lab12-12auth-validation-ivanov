using System.ComponentModel.DataAnnotations;

namespace wt_lab8_8razor_postgresql_ivanov.Models;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Введите название")]
    [StringLength(100, ErrorMessage = "Название не должно превышать 100 символов")]
    [Display(Name = "Название")]
    public string Name { get; set; } = string.Empty;

    [Display(Name = "Категория")]
    public string Category { get; set; } = string.Empty;

    [Required(ErrorMessage = "Введите цену")]
    [Range(0.01, 1000000, ErrorMessage = "Цена должна быть положительной")]
    [Display(Name = "Цена")]
    public decimal Price { get; set; }

    [Display(Name = "В наличии")]
    public bool IsAvailable { get; set; }

    [Display(Name = "Описание")]
    public string Description { get; set; } = string.Empty;
}