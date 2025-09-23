using FoodPriceComparison.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FoodPriceComparison.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<PlatformPrice> PlatformPrices { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PlatformPrice>().HasData(
                new PlatformPrice { Id = 1, DishName = "Margherita Pizza", PlatformName = "Zomato", Price = 250 },
                new PlatformPrice { Id = 2, DishName = "Margherita Pizza", PlatformName = "Swiggy", Price = 270 },
                new PlatformPrice { Id = 3, DishName = "Margherita Pizza", PlatformName = "UberEats", Price = 260 },

                new PlatformPrice { Id = 4, DishName = "Veg Burger", PlatformName = "Zomato", Price = 120 },
                new PlatformPrice { Id = 5, DishName = "Veg Burger", PlatformName = "Swiggy", Price = 110 },
                new PlatformPrice { Id = 6, DishName = "Veg Burger", PlatformName = "UberEats", Price = 115 },

                new PlatformPrice { Id = 7, DishName = "Pasta Alfredo", PlatformName = "Zomato", Price = 180 },
                new PlatformPrice { Id = 8, DishName = "Pasta Alfredo", PlatformName = "Swiggy", Price = 175 },
                new PlatformPrice { Id = 9, DishName = "Pasta Alfredo", PlatformName = "UberEats", Price = 185 },

                new PlatformPrice { Id = 10, DishName = "French Fries", PlatformName = "Zomato", Price = 90 },
                new PlatformPrice { Id = 11, DishName = "French Fries", PlatformName = "Swiggy", Price = 85 },
                new PlatformPrice { Id = 12, DishName = "French Fries", PlatformName = "UberEats", Price = 95 }
            );
        }

    }
}
