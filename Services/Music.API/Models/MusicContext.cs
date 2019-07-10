using System;
using Microsoft.EntityFrameworkCore;

namespace Music.API.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options):base(options)
        {
        }

        public DbSet<Music> Music { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Music>().ToTable("Music");
            modelBuilder.Entity<Music>().HasKey(p => p.Id);
            modelBuilder.Entity<Music>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Music>().Property(p => p.Year).IsRequired();
            modelBuilder.Entity<Music>().Property(p => p.Artist).IsRequired();
            modelBuilder.Entity<Music>().Property(p => p.Title).IsRequired();

            modelBuilder.Entity<Music>().HasData
                (
                    new Music { Id = 1, Year = 1990, Artist = "Ozzy Osbourne", Title = "Crazy Train" },
                    new Music { Id = 2, Year = 1990, Artist = "Slayer", Title = "Raining Blood" }
                );

        }
    }
}
