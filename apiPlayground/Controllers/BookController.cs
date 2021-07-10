using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace apiPlayground.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly DatabaseContext _myDbContext = new DatabaseContext();

        [HttpGet]
        public IEnumerable<int> Get()
        {
            return Enumerable.Range(1, 5).ToArray();
        }
    }
}
