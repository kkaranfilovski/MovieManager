using MovieManager.ServiceModels.MovieModels;

namespace MovieManager.Services.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<MovieDto> GetAllMovies();
        MovieDto GetMovieById(int id);
    }
}
