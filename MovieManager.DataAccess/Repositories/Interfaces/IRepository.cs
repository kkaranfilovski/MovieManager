using MovieManager.Domain.Models;

namespace MovieManager.DataAccess.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        public IQueryable<T> Query { get; }

        IEnumerable<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        int Update(T entity);
        int Delete(int id);
        IEnumerable<T> FilterBy(Func<T, bool> filter);
    }
}
