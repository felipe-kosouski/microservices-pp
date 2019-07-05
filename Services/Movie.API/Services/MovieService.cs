using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Movie.API.Domain.Models;
using Movie.API.Domain.Repositories;
using Movie.API.Domain.Services;

namespace Movie.API.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }
        public async Task<IEnumerable<Domain.Models.Movie>> ListAsync()
        {
            return await movieRepository.ListAsync();
        }
    }
}
