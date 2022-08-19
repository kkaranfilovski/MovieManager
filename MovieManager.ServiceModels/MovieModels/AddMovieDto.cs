using MovieManager.ServiceModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace MovieManager.ServiceModels.MovieModels
{
    public class AddMovieDto
    {
        [Required(ErrorMessage = "Enter title")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Enter Description")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Enter Year")]
        public int? Year { get; set; }
        [Required(ErrorMessage = "Enter Genre")]
        public string? Genre { get; set; }
    }
}
