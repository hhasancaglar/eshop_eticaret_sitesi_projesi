using EShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Günlük Laptop" });
            builder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Gaming Laptop" });
            builder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "İkisi Bir Arada Laptop" });

            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 1,
                Name = "Lenovo",
                Price = 5999M,
                Description = "Lenovo Intel Core i5 1035G1 8GB 1TB Freedos FHD Laptop",
                CategoryId = 1,
                ImageUrl = "\\Images\\lenovo-laptop.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\lenovo-laptop-small.jpg",
                IsOnRecommend = true
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 2,
                Name = "Asus",
                Price = 5899M,
                Description = "Asus AMD Ryzen 5 3500U 4GB 256GB SSD Freedos FHD Laptop",
                CategoryId = 1,
                ImageUrl = "\\Images\\asus-laptop.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\asus-laptop-small.jpg",
                IsOnRecommend = false,
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 3,
                Name = "Hp",
                Price = 6148M,
                Description = "HP Intel Core i5 10210U 8GB 256GB SSD MX110 Freedos Laptop",
                CategoryId = 1,
                ImageUrl = "\\Images\\hp-laptop.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\hp-laptop-small.jpg",
                IsOnRecommend = true
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 4,
                Name = "Casper",
                Price = 6499M,
                Description = "Casper Intel i5-1035G1 8GB 240GB SSD Windows 10 Home Laptop",
                CategoryId = 1,
                ImageUrl = "\\Images\\casper-laptop.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\casper-laptop-small.jpg",
                IsOnRecommend = false
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 5,
                Name = "Apple",
                Price = 7199M,
                Description = "Apple MacBook Air Intel Core i5 5350U 8GB 128GB SSD MacOS Sierra Laptop",
                CategoryId = 1,
                ImageUrl = "\\Images\\apple-laptop.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\apple-laptop-small.jpg",
                IsOnRecommend = false
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 6,
                Name = "Monster",
                Price = 8699M,
                Description = "Monster Intel Core i5 10300H 8GB 500GB SSD GTX1650Ti Freedos Gaming Laptop",
                CategoryId = 2,
                ImageUrl = "\\Images\\monster-gaming.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\monster-gaming-small.jpg",
                IsOnRecommend = false
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 7,
                Name = "MSI",
                Price = 9681M,
                Description = "MSI Bravo AMD Ryzen 7 4800H 8GB 512GB SSD RX 5500M Freedos Gaming Laptop",
                CategoryId = 2,
                ImageUrl = "\\Images\\msi-gaming.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\msi-gaming-small.jpg",
                IsOnRecommend = true
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 8,
                Name = "Acer",
                Price = 9999M,
                Description = "Acer Nitro 5 Intel Core i7 10750H 16GB 512GB SSD GTX1650Ti Freedos Gaming Laptop",
                CategoryId = 2,
                ImageUrl = "\\Images\\acer-gaming.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\acer-gaming-small.jpg",
                IsOnRecommend = true
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 9,
                Name = "HP",
                Price = 8799M,
                Description = "HP Pavilion AMD Ryzen 5 4600H 8GB 512GB SSD GTX 1650Ti Freedos Gaming Laptop",
                CategoryId = 2,
                ImageUrl = "\\Images\\hp-gaming.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\hp-gaming-small.jpg",
                IsOnRecommend = false
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 10,
                Name = "Dell",
                Price = 13649M,
                Description = "Dell Intel Core i7 10750H 16GB 512GB SSD RTX 2060 Windows 10 Home Gaming Laptop",
                CategoryId = 2,
                ImageUrl = "\\Images\\dell-gaming.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\dell-gaming-small.jpg",
                IsOnRecommend = true
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 11,
                Name = "Lenovo",
                Price = 12289M,
                Description = "Lenovo YogaIntel Core i7 10510U 8GB 512GB SSD Windows 10 Home İkisi Bir Arada Laptop",
                CategoryId = 3,
                ImageUrl = "\\Images\\lenovo-2si1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\lenovo-2si1-small.jpg",
                IsOnRecommend = true
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 12,
                Name = "HP",
                Price = 12999M,
                Description = "HP Intel Core i5 8265U 8GB 256GB SSD Windows 10 Home İkisi Bir Arada Laptop",
                CategoryId = 3,
                ImageUrl = "\\Images\\hp-2si1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\hp-2si1-small.jpg",
                IsOnRecommend = false
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 13,
                Name = "Dell",
                Price = 16099M,
                Description = "Dell XPS13 7390 Intel Core i7 1065G7 16GB 512GB SSD Windows 10 Pro İkisi Bir Arada Laptop",
                CategoryId = 3,
                ImageUrl = "\\Images\\dell-2si1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\dell-2si1-small.jpg",
                IsOnRecommend = false
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 14,
                Name = "Toshiba",
                Price = 14149M,
                Description = "Toshiba Intel Core i7 7500U 8GB 512GB SSD Windows 10 Pro İkisi Bir Arada Laptop",
                CategoryId = 3,
                ImageUrl = "\\Images\\toshiba-2si1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\toshiba-2si1-small.jpg",
                IsOnRecommend = true
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 15,
                Name = "Asus",
                Price = 13499M,
                Description = "Asus VivoBook Intel Core i7 10750H 8GB 512GB SSD GTX 1650 Windows 10 Home İkisi Bir Arada Laptop",
                CategoryId = 3,
                ImageUrl = "\\Images\\asus-2si1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\asus-2si1-small.jpg",
                IsOnRecommend = false
            });
        }
    }
}
