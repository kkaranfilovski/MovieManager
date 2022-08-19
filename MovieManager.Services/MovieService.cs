using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieManager.DataAccess.Repositories.Interfaces;
using MovieManager.Domain.Enums;
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
            if (movies.Any())
            {
                return movies;
            }
            else
            {
                throw new Exception("No movies");
            }
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

        public IEnumerable<MovieDto> GetMovieByGenre(string genre)
        {
            var movies = _repo.FilterBy(x => x.Genre.ToString() == genre).Select(_mapper.Map<Movie, MovieDto>);
            
            if (movies.Any())
            {
                return movies;
            }
            else
            {
                throw new Exception("movies with that genre does not exist");
            }
        }

        public void AddMovie(AddMovieDto movie)
        {
            var newMovie = _repo.Insert(_mapper.Map<Movie>(movie));
        }

        public void UpdateMovie(MovieDto movie)
        {
            var updatedMovie = _repo.Update(_mapper.Map<Movie>(movie));
        }

        public void DeleteMovie(int id)
        {
            var movieToDelete = _repo.Delete(id);

        }
    }
}
