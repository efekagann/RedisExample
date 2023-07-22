﻿using Microsoft.EntityFrameworkCore;

namespace RedisExample.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
                    new Product() { Id = 1, Name = "Kitap", Price = 30 },
                    new Product() { Id = 2, Name = "Kalem", Price = 15 },
                    new Product() { Id = 3, Name = "Defter", Price = 20 }
                );





            base.OnModelCreating(modelBuilder);
        }
    }
}
