using Microsoft.EntityFrameworkCore;
using SimpleProject.Models;

namespace SimpleProject.Data
{
    public  class ApplicationDbContext: DbContext
    {
        public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

      public  DbSet<Coontact> contacts{ get; set; }
      public  DbSet<Portfolio> Portfolios { get; set; }
    }
}
