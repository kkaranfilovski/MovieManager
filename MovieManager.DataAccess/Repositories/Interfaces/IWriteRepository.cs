using MovieManager.Domain.Models;

namespace MovieManager.DataAccess.Repositories.Interfaces
{
    public interface IWriteRepository<T> where T : BaseEntity
    {
        int Insert(T entity);
        int Update(T entity);
        int Delete(int id);
    }
}
