using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie.API.Domain.Models;
using Movie.API.Domain.Repositories;
using Movie.API.Persistence.Contexts;

namespace Movie.API.Persistence.Repositories
{
    public class MovieRepository : BaseRepository, IMovieRepository
    {
        public MovieRepository(AppDbContext context) : base(context){}

        public async Task<IEnumerable<Domain.Models.Movie>> ListAsync()
        {
            return await context.Movies.ToListAsync();
        }
    }
}
