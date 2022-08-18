using MovieManager.ServiceModels.Enums;

namespace MovieManager.ServiceModels.MovieModels
{
    public class AddMovieDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
    }
}
