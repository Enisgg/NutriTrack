using Microsoft.EntityFrameworkCore;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.Database;

public class NutritionDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public DbSet<Meal> Meals { get; set; }

    public DbSet<WeightHistory> WeightHistory { get; set; }

    public DbSet<WeightEntry> WeightEntries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=nutrition.db");
    }
}