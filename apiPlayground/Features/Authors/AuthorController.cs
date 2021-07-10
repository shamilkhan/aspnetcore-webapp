using System;
using System.Collections.Generic;
using apiPlayground.Domain;
using Microsoft.AspNetCore.Mvc;

namespace apiPlayground.Features.Authors
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController: ControllerBase
    {
        private readonly DatabaseContext _context = new DatabaseContext();

        [HttpGet]
        public IEnumerable<Author> Get()
        {
            return _context.Authors;
        }
    }
}
