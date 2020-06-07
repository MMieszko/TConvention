using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client.Application.Controllers
{
    public class UserController : ApplicationController
    {
        public Task<List<object>> GetUsers()
        {
            return Task.FromResult(new List<object>());
        }
    }
}
