using Microsoft.EntityFrameworkCore;

namespace GitBuild.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<Language> Lnaguages {get; set; }
    }
}