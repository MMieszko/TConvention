using Client.Domain;
using System.Threading.Tasks;

namespace Client.Infrastructure.Ef
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : IEntity
    {
        protected readonly EfContext EfContext;

        public Repository(EfContext efContext)
        {
            EfContext = efContext;
        }
        
        public Task AddAsync(TEntity entity)
        {
            return Task.CompletedTask;
        }

        public Task DeleteAsync(TEntity entity)
        {
            return Task.CompletedTask;
        }

        public Task<TEntity> GetByIdAsync(long id)
        {
            return null;
        }
    }
}