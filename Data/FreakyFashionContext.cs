using FreakyFashion.Data.Entities;
using FreakyFashion.Data.EntityConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion.Data
{
    public class FreakyFashionContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public FreakyFashionContext(DbContextOptions<FreakyFashionContext> options)
            :base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
        }
    }
}
