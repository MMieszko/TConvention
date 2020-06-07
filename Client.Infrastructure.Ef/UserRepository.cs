using System.Threading.Tasks;
using Client.Domain;

namespace Client.Infrastructure.Ef
{
    public class UserRepository : Repository<User>, IRepository<User>
    {
        public UserRepository(EfContext efContext)
            :base(efContext)
        {
            
        }

        public Task AddAsync(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetByIdAsync(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}