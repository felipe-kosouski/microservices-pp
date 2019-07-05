using System;
using Microsoft.EntityFrameworkCore;

namespace Movie.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Domain.Models.Movie> Movies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Domain.Models.Movie>().ToTable("Movies");
            modelBuilder.Entity<Domain.Models.Movie>().HasKey(p => p.Id);
            modelBuilder.Entity<Domain.Models.Movie>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Domain.Models.Movie>().Property(p => p.Year).IsRequired();
            modelBuilder.Entity<Domain.Models.Movie>().Property(p => p.Title).IsRequired();

            modelBuilder.Entity<Domain.Models.Movie>().HasData
                (
                    new Domain.Models.Movie { Id = 100, Year = 1990, Title = "Just a sample Movie" },
                    new Domain.Models.Movie { Id = 200, Year = 1990, Title = "Just another sample Movie" }
                );
        }

    }
}
