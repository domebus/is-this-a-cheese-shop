using System;
using System.Collections.Generic;
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

        public DbSet<CheesyApi.Models.Cheese> Cheese { get; set; }
    }
}
