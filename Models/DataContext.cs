using EfDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EfDemo.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Test",
                    Products = new List<Product>()
                },
                 new Category
                 {
                     Id = 2,
                     Name = "Test 2222",
                     Products = new List<Product>()
                 }
            );
        }
    }
}
