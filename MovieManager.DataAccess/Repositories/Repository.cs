using Microsoft.EntityFrameworkCore;
using MovieManager.DataAccess.Data;
using MovieManager.DataAccess.Repositories.Interfaces;
using MovieManager.Domain.Models;

namespace MovieManager.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DbSet<T> _source;

        public Repository(MovieManagerDbContext dbContext) 
        {
            _source = dbContext.Set<T>();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FilterBy(Func<T, bool> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public int Update(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query 
        { 
            get
            {
                return _source;
            }
        }
    }
}
