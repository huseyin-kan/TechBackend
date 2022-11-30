using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EcommContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=eCommerce;Trusted_Connection=true");

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Consoles> Consoles { get; set; }
        public DbSet<Headphone> Headphones { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Mouse> Mouses { get; set; }
        public DbSet<MousePad> MousePads { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<KeyboardAndMouse> KeyboardMouse { get; set; }
        public DbSet<Gamepad> Gamepads { get; set; }
        public DbSet<Computer> Computers { get; set; }



    }
}
