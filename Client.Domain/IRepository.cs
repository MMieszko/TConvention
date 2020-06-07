using System;
using System.Threading.Tasks;

namespace Client.Domain
{
    public interface IRepository<TEntity> : IRepository
        where TEntity : IEntity
    {
        Task AddAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(long id);
    }

    public interface IRepository
    {

    }
}
