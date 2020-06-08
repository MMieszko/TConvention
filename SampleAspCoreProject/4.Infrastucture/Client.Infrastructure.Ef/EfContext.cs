using System.Collections.Generic;
using Client.Domain;

namespace Client.Infrastructure.Ef
{
    public class EfContext
    {
        public ICollection<User> Users { get; }
    }
}