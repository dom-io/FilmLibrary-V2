using System.ComponentModel.DataAnnotations;

namespace FilmLibrary_V2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ReleaseYear { get; set; }
    }
}
