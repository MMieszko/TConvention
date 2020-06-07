using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Client.AspCore.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ApiController
    {
        [HttpGet, Route("")]
        public async Task<MyResponse<IEnumerable<string>>> Get()
        {
            return null;
        }

        [HttpGet("{id}"), Route("")]
        public async Task<MyResponse<string>> Get(int id)
        {
            return null;
        }
    }
}
