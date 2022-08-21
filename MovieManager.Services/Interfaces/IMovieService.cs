using MovieManager.ServiceModels.MovieModels;

namespace MovieManager.Services.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<MovieDto> GetAllMovies();
        MovieDto GetMovieById(int id);    
        IEnumerable<MovieDto> GetMovieByGenre(string genre);
        int AddMovie(AddMovieDto movie);
        int UpdateMovie(int id, EditMovieDto movie);   
        int DeleteMovie(int id);
    }
}
