using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movie.API.Domain.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Models.Movie>> ListAsync();
    }
}
