using Microsoft.EntityFrameworkCore;

namespace dotNetEFCoreV3.DataContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CategoryEntity> CategoryEntities => Set<CategoryEntity>();

    }
}
