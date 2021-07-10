using System;
using Microsoft.EntityFrameworkCore;

namespace apiPlayground
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=local.db");
        }
    }
}
