using System;
namespace Music.API.Models
{
    public class Music
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
    }
}
