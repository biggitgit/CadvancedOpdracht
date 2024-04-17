using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadvancedOpdracht.Models;

namespace CadvancedOpdracht.Data
{
    public class CadvancedOpdrachtContext : DbContext
    {
        public CadvancedOpdrachtContext (DbContextOptions<CadvancedOpdrachtContext> options)
            : base(options)
        {
        }

        public DbSet<CadvancedOpdracht.Models.Landlord> Landlord { get; set; } = default!;
        public DbSet<CadvancedOpdracht.Models.Location> Location { get; set; } = default!;
        public DbSet<CadvancedOpdracht.Models.Image> Image { get; set; } = default!;
    }
}
