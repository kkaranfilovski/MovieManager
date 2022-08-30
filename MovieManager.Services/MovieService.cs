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
        private readonly IRepository<Movie> _repo;
        private readonly IMapper _mapper;
        private readonly IEFDapperRepository<Movie> _mixedRepo;

        public MovieService(IRepository<Movie> repo, IMapper mapper, IEFDapperRepository<Movie> mixedRepo)
        {
            _repo = repo;
            _mapper = mapper;
            _mixedRepo = mixedRepo;
        }
        public IEnumerable<MovieDto> GetAllMovies()
        {
            //var movies = _repo.GetAll().Select(_mapper.Map<Movie, MovieDto>);
            //if (movies.Any())
            //{
            //    return movies;
            //}
            //else
            //{
            //    throw new Exception("No movies");
            //}

            var movies = _mixedRepo.GetAll().Select(_mapper.Map<Movie, MovieDto>);
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
            //var movie = _repo.GetById(id);

            //if(movie == null)
            //{
            //    throw new Exception("movie not found");
            //}

            //return _mapper.Map<Movie,MovieDto>(movie);

            var movie = _mixedRepo.GetById(id);

            if (movie == null)
            {
                throw new Exception("movie not found");
            }

            return _mapper.Map<Movie, MovieDto>(movie);
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

        public int AddMovie(AddMovieDto movie)
        {
            var newMovie = _repo.Insert(_mapper.Map<Movie>(movie));
            return newMovie;
        }

        public int UpdateMovie(int id, EditMovieDto movie)
        {
            var movieDb = _repo.GetById(id);
            if(movieDb == null)
            {
                throw new Exception("movie not found");
            }
            if (String.IsNullOrWhiteSpace(movie.Title))
            {
                throw new Exception("Title cannot be empty");
            }
            if(movie.Description?.Length > 250)
            {
                throw new Exception("Description cannot be longer then 250 characaters");
            }
            if (String.IsNullOrWhiteSpace(movie.Genre))
            {
                throw new Exception("Genre cannot be empty");
            }

            var editedMovie = _mapper.Map<Movie>(movie);
            var updatedMovie = _repo.Update(editedMovie);
            return updatedMovie;    
        }

        public int DeleteMovie(int id)
        {
            var movieToDelete = _repo.Delete(id);
            return movieToDelete;
        }
    }
}
