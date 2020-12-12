using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntryPoint___test_task.Models;
using Microsoft.EntityFrameworkCore;

namespace EntryPoint___test_task.Data
{
    public class DbTestcontext : DbContext
    {

     public DbTestcontext(DbContextOptions<DbTestcontext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Order>().ToTable("Order");
        }


    }
}
