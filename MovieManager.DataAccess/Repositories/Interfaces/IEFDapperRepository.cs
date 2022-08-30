using MovieManager.Domain.Models;

namespace MovieManager.DataAccess.Repositories.Interfaces
{
    public interface IEFDapperRepository<T> : IWriteRepository<T>, IReadRepository<T> where T : BaseEntity
    {
    }
}
