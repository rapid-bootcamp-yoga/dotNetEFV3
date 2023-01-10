using Microsoft.EntityFrameworkCore;

namespace dotNetEFCoreV3.DataContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CategoryEntity> CategoryEntities => Set<CategoryEntity>();
        public DbSet<CompanyEntity> CompanyEntities => Set<CompanyEntity>();
        public DbSet<CustomerEntity> customerEntities=> Set<CustomerEntity>();
        public DbSet<OrderEntity> OrderEntities => Set<OrderEntity>();
        public DbSet<ProductEntity> productEntities=> Set<ProductEntity>();

    }
}
