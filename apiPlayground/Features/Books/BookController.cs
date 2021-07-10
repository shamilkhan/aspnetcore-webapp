using System;
using System.Collections.Generic;
using apiPlayground.Domain;
using Microsoft.AspNetCore.Mvc;

namespace apiPlayground.Features.Books
{
    [ApiController]
    [Route("[controller]")]
    public class BookController: ControllerBase
    {
        private readonly DatabaseContext _context = new DatabaseContext();

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _context.Books;
        }
    }
}
