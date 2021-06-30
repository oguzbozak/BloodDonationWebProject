using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanver.Data
{
    public class RandevuContext : DbContext
    {
        public RandevuContext()
        {
        }

        public RandevuContext(DbContextOptions<RandevuContext> options)
            : base(options)
        {

        }

        public DbSet<Randevular> Randevulars { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-S8H06KN\\SQL2019;Database=Araba;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
