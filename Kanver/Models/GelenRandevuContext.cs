using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanver.Models
{
    public class GelenRandevuContext : DbContext
    {
        public GelenRandevuContext(DbContextOptions<GelenRandevuContext> options) : base(options)
        {

        }

        public DbSet<RandevuKontrol> RandevuKontrol { get; set; }
    }
}
