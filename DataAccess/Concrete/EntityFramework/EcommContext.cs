using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EcommContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"LAPTOP-HONK2CV0;Database=eCommerce;Trusted_Connection=true");
        }
        DbSet<Product> Products { get; set; }
        DbSet<Card> Cards { get; set; }
        DbSet<Category> Categories { get; set; }
        //DbSet<Consoles> Consoles { get; set; }
        DbSet<Headphone> Headphones { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<Mouse> Mouses { get; set; }
        DbSet<MousePad> MousePads { get; set; }
        DbSet<Keyboard> Keyboards { get; set; }
        DbSet<KeyboardAndMouse> KeyboardAndMouses { get; set; }
        DbSet<Gamepad> Gamepads { get; set; }
        DbSet<Computer> Computers { get; set; }



    }
}
