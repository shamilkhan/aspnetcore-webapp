using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        [HttpPost]
        public async Task<Author> Post()
        {
            var author = new Author();
            _context.Add(author);
            await _context.SaveChangesAsync();
            return author;
        }
    }
}
