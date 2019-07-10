using System;
using Microsoft.EntityFrameworkCore;

namespace Movie.API.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options):base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().ToTable("Movies");
            modelBuilder.Entity<Movie>().HasKey(p => p.Id);
            modelBuilder.Entity<Movie>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Movie>().Property(p => p.Year).IsRequired();
            modelBuilder.Entity<Movie>().Property(p => p.Title).IsRequired();

            modelBuilder.Entity<Movie>().HasData
                (
                    new Movie { Id = 100, Year = 1990, Title = "Just a sample Movie" },
                    new Movie { Id = 200, Year = 1990, Title = "Just another sample Movie" }
                );
        }
    }
}
