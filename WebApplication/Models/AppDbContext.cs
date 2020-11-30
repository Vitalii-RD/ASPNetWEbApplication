using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Wood" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Clay" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Sand" });

            //seed pies

            modelBuilder.Entity<Material>().HasData(new Material
            {
                MaterialId = 1,
                Name = "Wood #1",
                Price = 10.95M,
                ShortDescription = "Good wood!",
                LongDescription ="Good, buy it now",
                CategoryId = 1,
                ImageUrl = "/images/wood2.jpg",
                InStock = true,
                IsMaterialOfTheWeek = false,
                ImageThumbnailUrl = "/images/wood2.jpg"
            });

            modelBuilder.Entity<Material>().HasData(new Material
            {
                MaterialId = 2,
                Name = "Clay #1",
                Price = 12.95M,
                ShortDescription = "Good clay!",
                LongDescription = "Good, buy it now",
                CategoryId = 2,
                ImageUrl = "/images/clay.jpg",
                InStock = true,
                IsMaterialOfTheWeek = true,
                ImageThumbnailUrl = "/images/clay.jpg"
            });

            modelBuilder.Entity<Material>().HasData(new Material
            {
                MaterialId = 3,
                Name = "Sand #1",
                Price = 15.95M,
                ShortDescription = "Good sand!",
                LongDescription = "Good, buy it now",
                CategoryId = 3,
                ImageUrl = "/images/sand.jpg",
                InStock = true,
                IsMaterialOfTheWeek = true,
                ImageThumbnailUrl = "/images/sand.jpg"
            });

            modelBuilder.Entity<Material>().HasData(new Material
            {
                MaterialId = 4,
                Name = "Wood #4",
                Price = 10.95M,
                ShortDescription = "Good wood!",
                LongDescription = "Good, buy it now",
                CategoryId = 1,
                ImageUrl = "/images/wood.jpg",
                InStock = true,
                IsMaterialOfTheWeek = false,
                ImageThumbnailUrl = "/images/wood.jpg"
            });
        }
    }
}
