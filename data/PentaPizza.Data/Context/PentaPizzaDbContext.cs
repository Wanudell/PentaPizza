using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaPizza.Data.Context
{
    public class PentaPizzaDbContext : DbContext
    {
        public PentaPizzaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(
                new Pizza { Id = 1, Name = "Margherita", Price = 5, Ingredients = "Tomato , Mozarella" },
                new Pizza { Id = 2, Name = "Bufala", Price = 6, Ingredients = "Tomato , Mozarella, Di Bufala" },
                new Pizza { Id = 3, Name = "Romana", Price = 5, Ingredients = "Tomato , Mozarella, Anchovies, Oregano, Oil" },
                new Pizza { Id = 4, Name = "Diavola", Price = 7.5, Ingredients = "Tomato , Mozarella, Spicy Salami" },
                new Pizza { Id = 5, Name = "Mozarella", Price = 5, Ingredients = "Mozarella, Oregano" });
        }
    }
}