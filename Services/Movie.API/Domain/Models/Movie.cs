using System;
namespace Movie.API.Domain.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
    }
}
