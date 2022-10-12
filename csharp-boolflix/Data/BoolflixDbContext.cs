using csharp_boolflix.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix_3.Context
{
    public class BoolflixDbContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<TVSeries> TvSeries { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<MediaInfo> MediaInfos { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<Genre> Genres { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=csharp-boolflix;Integrated Security=True");
        }
    }

}