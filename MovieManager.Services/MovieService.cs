using AutoMapper;
using MovieManager.DataAccess.Repositories.Interfaces;
using MovieManager.Domain.Models;
using MovieManager.ServiceModels.MovieModels;
using MovieManager.Services.Interfaces;

namespace MovieManager.Services
{
    public class MovieService : IMovieService
    {
        private IRepository<Movie> _repo;
        private readonly IMapper _mapper;

        public MovieService(IRepository<Movie> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public IEnumerable<MovieDto> GetAllMovies()
        {
            var movies = _repo.GetAll().Select(_mapper.Map<Movie, MovieDto>);
            return movies;
        }

        public MovieDto GetMovieById(int id)
        {
            var movie = _repo.GetById(id);

            if(movie == null)
            {
                throw new Exception("movie not found");
            }

            return _mapper.Map<Movie,MovieDto>(movie);
        }
    }
}
