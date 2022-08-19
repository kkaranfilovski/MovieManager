using MovieManager.DataAccess.Data;
using MovieManager.DataAccess.Repositories.Interfaces;
using MovieManager.Domain.Models;

namespace MovieManager.DataAccess.Repositories
{
    public class MovieRepository : IRepository<Movie>
    {
        
        private readonly MovieManagerDbContext _context;

        public IQueryable<Movie> Query => throw new NotImplementedException();

        public MovieRepository(MovieManagerDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetAll()
        {
            var movies = _context.Movies.ToList();
            return movies; 
        }
        
        public Movie GetById(int id)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            return movie;
        }

        public IEnumerable<Movie> FilterBy(Func<Movie, bool> filter)
        {
            var filtered = _context.Movies.Where(filter);
            return filtered;
        }

        public int Insert(Movie entity)
        {
            _context.Movies.Add(entity);
            _context.SaveChanges();
            return _context.Movies.ToList().Count;
        }

        public int Update(Movie entity)
        {
            _context.Movies.Update(entity);
            _context.SaveChanges();
            return _context.Movies.ToList().Count;
        }

        public int Delete(int id)
        {
            var deletedMovie = GetById(id);
            
            if (deletedMovie != null)
            {
                _context.Movies.Remove(deletedMovie);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Movie with that ID was not found!");
            }
            
            return _context.Movies.ToList().Count;
        }
    }
}
