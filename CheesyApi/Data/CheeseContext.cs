using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CheesyApi.Models
{
    public class CheeseContext : DbContext
    {
        public CheeseContext (DbContextOptions<CheeseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cheese>().HasData(
                new Cheese { 
                    Id = 1, 
                    Name = "LE GRUYÈRE AOP", 
                    PricePerKilogram = 63.8M, 
                    Color = Color.FromArgb(249, 221, 141) 
                }
            );
        }


        public DbSet<CheesyApi.Models.Cheese> Cheese { get; set; }
    }
}
