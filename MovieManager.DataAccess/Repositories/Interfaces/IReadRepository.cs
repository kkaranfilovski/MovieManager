using MovieManager.Domain.Models;

namespace MovieManager.DataAccess.Repositories.Interfaces
{
    public interface IReadRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> FilterBy(Func<T, bool> filter);
    }
}
