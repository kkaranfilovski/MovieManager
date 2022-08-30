using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using MovieManager.DataAccess.Data;
using MovieManager.DataAccess.Repositories.Interfaces;
using MovieManager.Domain.Models;

namespace MovieManager.DataAccess.Repositories
{
    public class EFDapperMovieRepository : IEFDapperRepository<Movie>
    {
        private readonly MovieManagerDbContext _context;

        private readonly IConfiguration _configuration;
        private readonly string _connString = "Server=.;Database=MovieManager_DB;Trusted_Connection=True;";

        public EFDapperMovieRepository(MovieManagerDbContext context)
        {
            _context = context;
        }

        // read

        public IEnumerable<Movie> GetAll()
        {
            using(SqlConnection connection = new SqlConnection(_connString))
            {
                connection.Open();

                var query = "select * from dbo.Movies";

                var movies = connection.Query<Movie>(query);

                return movies;
            }
        }

        public Movie GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                connection.Open();

                var query = "select * from dbo.Movies where Id = @id";

                var movie = connection.Query<Movie>(query).FirstOrDefault();

                return movie;
            }
        }

        public IEnumerable<Movie> FilterBy(Func<Movie, bool> filter)
        {
            throw new NotImplementedException();
        }

        // write

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

            return deletedMovie.Id;
        }

        public int Insert(Movie entity)
        {
            _context.Movies.Add(entity);
            _context.SaveChanges();
            return _context.Movies.ToList().Count;
        }

        public int Update(Movie entity)
        {
            _context.ChangeTracker.Clear();
            _context.Movies.Update(entity);
            _context.SaveChanges();
            return entity.Id;
        }
    }
}
