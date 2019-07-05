using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movie.API.Domain.Repositories
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Models.Movie>> ListAsync();
    }
}
