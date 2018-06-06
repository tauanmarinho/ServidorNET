using Microsoft.EntityFrameworkCore;
using GitBuild.Domain.Language;

namespace GitBuild.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Language> Languages {get; set; }
    }
}