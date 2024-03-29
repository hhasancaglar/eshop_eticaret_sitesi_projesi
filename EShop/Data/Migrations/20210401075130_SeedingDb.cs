﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.Data.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Günlük Laptop" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Gaming Laptop" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "İkisi Bir Arada Laptop" });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "ComputerId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnRecommend", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Lenovo Intel Core i5 1035G1 8GB 1TB Freedos FHD Laptop", "\\Images\\thumbnails\\lenovo-laptop-small.jpg", "\\Images\\lenovo-laptop.jpg", true, "Lenovo", 5999m },
                    { 2, 1, "Asus AMD Ryzen 5 3500U 4GB 256GB SSD Freedos FHD Laptop", "\\Images\\thumbnails\\asus-laptop-small.jpg", "\\Images\\asus-laptop.jpg", false, "Asus", 5899m },
                    { 3, 1, "HP Intel Core i5 10210U 8GB 256GB SSD MX110 Freedos Laptop", "\\Images\\thumbnails\\hp-laptop-small.jpg", "\\Images\\hp-laptop.jpg", true, "Hp", 6148m },
                    { 4, 1, "Casper Intel i5-1035G1 8GB 240GB SSD Windows 10 Home Laptop", "\\Images\\thumbnails\\casper-laptop-small.jpg", "\\Images\\casper-laptop.jpg", false, "Casper", 6499m },
                    { 5, 1, "Apple MacBook Air Intel Core i5 5350U 8GB 128GB SSD MacOS Sierra Laptop", "\\Images\\thumbnails\\apple-laptop-small.jpg", "\\Images\\apple-laptop.jpg", false, "Apple", 7199m },
                    { 6, 2, "Monster Intel Core i5 10300H 8GB 500GB SSD GTX1650Ti Freedos Gaming Laptop", "\\Images\\thumbnails\\monster-gaming-small.jpg", "\\Images\\monster-gaming.jpg", false, "Monster", 8699m },
                    { 7, 2, "MSI Bravo AMD Ryzen 7 4800H 8GB 512GB SSD RX 5500M Freedos Gaming Laptop", "\\Images\\thumbnails\\msi-gaming-small.jpg", "\\Images\\msi-gaming.jpg", true, "MSI", 9681m },
                    { 8, 2, "Acer Nitro 5 Intel Core i7 10750H 16GB 512GB SSD GTX1650Ti Freedos Gaming Laptop", "\\Images\\thumbnails\\acer-gaming-small.jpg", "\\Images\\acer-gaming.jpg", true, "Acer", 9999m },
                    { 9, 2, "HP Pavilion AMD Ryzen 5 4600H 8GB 512GB SSD GTX 1650Ti Freedos Gaming Laptop", "\\Images\\thumbnails\\hp-gaming-small.jpg", "\\Images\\hp-gaming.jpg", false, "HP", 8799m },
                    { 10, 2, "Dell Intel Core i7 10750H 16GB 512GB SSD RTX 2060 Windows 10 Home Gaming Laptop", "\\Images\\thumbnails\\dell-gaming-small.jpg", "\\Images\\dell-gaming.jpg", true, "Dell", 13649m },
                    { 11, 3, "Lenovo YogaIntel Core i7 10510U 8GB 512GB SSD Windows 10 Home İkisi Bir Arada Laptop", "\\Images\\thumbnails\\lenovo-2si1-small.jpg", "\\Images\\lenovo-2si1.jpg", true, "Lenovo", 12289m },
                    { 12, 3, "HP Intel Core i5 8265U 8GB 256GB SSD Windows 10 Home İkisi Bir Arada Laptop", "\\Images\\thumbnails\\hp-2si1-small.jpg", "\\Images\\hp-2si1.jpg", false, "HP", 12999m },
                    { 13, 3, "Dell XPS13 7390 Intel Core i7 1065G7 16GB 512GB SSD Windows 10 Pro İkisi Bir Arada Laptop", "\\Images\\thumbnails\\dell-2si1-small.jpg", "\\Images\\dell-2si1.jpg", false, "Dell", 16099m },
                    { 14, 3, "Toshiba Intel Core i7 7500U 8GB 512GB SSD Windows 10 Pro İkisi Bir Arada Laptop", "\\Images\\thumbnails\\toshiba-2si1-small.jpg", "\\Images\\toshiba-2si1.jpg", true, "Toshiba", 14149m },
                    { 15, 3, "Asus VivoBook Intel Core i7 10750H 8GB 512GB SSD GTX 1650 Windows 10 Home İkisi Bir Arada Laptop", "\\Images\\thumbnails\\asus-2si1-small.jpg", "\\Images\\asus-2si1.jpg", false, "Asus", 13499m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
