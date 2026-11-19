using Microsoft.EntityFrameworkCore;
using wt_lab8_8razor_postgresql_ivanov.Models;

namespace wt_lab8_8razor_postgresql_ivanov.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}