using wt_lab5_5razor_ivanov.Models;

namespace wt_lab5_5razor_ivanov.Data
{
    public static class ProductStore
    {
        public static List<Product> Products { get; } = new()
        {
            new Product { Id = 1, Name = "Ноутбук", Category = "Компьютеры", Price = 2500, IsAvailable = true, Description = "Мощный ноутбук" },
            new Product { Id = 2, Name = "Мышь", Category = "Аксессуары", Price = 80, IsAvailable = true, Description = "Беспроводная мышь" },
            new Product { Id = 3, Name = "Клавиатура", Category = "Аксессуары", Price = 120, IsAvailable = false, Description = "Механическая клавиатура" },
            new Product { Id = 4, Name = "Монитор", Category = "Компьютеры", Price = 800, IsAvailable = true, Description = "27-дюймовый монитор" },
            new Product { Id = 5, Name = "Наушники", Category = "Аксессуары", Price = 150, IsAvailable = true, Description = "Игровые наушники" }
        };
    }
}