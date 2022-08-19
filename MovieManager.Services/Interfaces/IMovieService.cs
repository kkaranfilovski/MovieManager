using MovieManager.ServiceModels.MovieModels;

namespace MovieManager.Services.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<MovieDto> GetAllMovies();
        MovieDto GetMovieById(int id);    
        IEnumerable<MovieDto> GetMovieByGenre(string genre);
        void AddMovie(AddMovieDto movie);
        void UpdateMovie(MovieDto movie);   
        void DeleteMovie(int id);
    }
}
