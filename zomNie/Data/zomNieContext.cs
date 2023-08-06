using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using zomNie.Models;

namespace zomNie.Data
{
    public class zomNieContext : DbContext
    {
        public zomNieContext (DbContextOptions<zomNieContext> options)
            : base(options)
        {
        }

        public DbSet<zomNie.Models.Category> Category { get; set; } = default!;

        public DbSet<zomNie.Models.Product>? Product { get; set; }

        public DbSet<zomNie.Models.User>? User { get; set; }
    }
}
