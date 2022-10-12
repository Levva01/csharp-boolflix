using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharp_boolflix.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Data
{
    public class BoolflixContext : DbContext
    {
        public BoolflixContext (DbContextOptions<BoolflixContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Film { get; set; }
        public DbSet<TVSeries> TvSerie { get; set; }
        public DbSet<Episode> Episode { get; set; }
        public DbSet<MediaInfo> MediaInfo { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Feature> Feature { get; set; }
        public DbSet<Genre> Genre { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db_boolflix;Integrated Security=True");
        }

    }
}
