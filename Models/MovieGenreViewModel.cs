using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        // List of movies to display
        public List<Movie> Movies { get; set; } = new List<Movie>();

        // List of genres for dropdown
        public SelectList Genres { get; set; }

        // Selected genre from dropdown
        public string? MovieGenre { get; set; }

        // Search string from the search box
        public string? SearchString { get; set; }
    }
}
