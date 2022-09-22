using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=northwind;User Id=postgres;Password=paspos;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasNoKey();
            modelBuilder.Entity<Category>().HasNoKey();
            modelBuilder.Entity<Order>().HasNoKey();
        }

        public DbSet<Product> products { get; set; }

        public DbSet<Category> categories { get; set; }

        public DbSet<Customer> customers { get; set; }

        public DbSet<Order> orders { get; set; }
    }
}

