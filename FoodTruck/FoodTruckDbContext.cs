using FoodTruck.Models.Business.Cupboard;
using FoodTruck.Models.Business.Fridge;
using FoodTruck.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace FoodTruck;

public class FoodTruckDbContext : DbContext
{
    public DbSet<CupboardStock> CupboardStock { get; set; }
    public DbSet<FridgeStock> FridgeStock { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = @"Server=localhost;Port=5432;Database=foodtruck;Username=foodtruck;Password=foodtruck;";
        optionsBuilder.UseNpgsql(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CupboardStock>().HasData(
            new CupboardStock { Item = nameof(Egg), Quantity = 0 },
            new CupboardStock { Item = nameof(Garlic), Quantity = 0 },
            new CupboardStock { Item = nameof(Onion), Quantity = 0 });

        modelBuilder.Entity<FridgeStock>().HasData(
            new FridgeStock { Item = nameof(Beef), Quantity = 0 },
            new FridgeStock { Item = nameof(Butter), Quantity = 0 },
            new FridgeStock { Item = nameof(Cheese), Quantity = 0 },
            new FridgeStock { Item = nameof(Ham), Quantity = 0 },
            new FridgeStock { Item = nameof(Pancetta), Quantity = 0 },
            new FridgeStock { Item = nameof(Pepperoni), Quantity = 0 },
            new FridgeStock { Item = nameof(Pineapple), Quantity = 0 },
            new FridgeStock { Item = nameof(RedChilli), Quantity = 0 },
            new FridgeStock { Item = nameof(TomatoSauce), Quantity = 0});
    }
}
