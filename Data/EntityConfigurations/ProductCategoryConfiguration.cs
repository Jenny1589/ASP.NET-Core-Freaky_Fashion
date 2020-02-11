using FreakyFashion.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakyFashion.Data.EntityConfigurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategory")
                .HasKey(pc => new { pc.ProductId, pc.CategoryId });

            builder.HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductId);

            builder.HasOne(pc => pc.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(pc => pc.CategoryId);

            builder.HasData(new ProductCategory[]
            {
                new ProductCategory(1, 1),
                new ProductCategory(1, 3),
                new ProductCategory(1, 6),
                new ProductCategory(2, 2),
                new ProductCategory(2, 6),
                new ProductCategory(3, 2),
                new ProductCategory(3, 5),
                new ProductCategory(4, 1),
                new ProductCategory(4, 5),
                new ProductCategory(5, 3),
                new ProductCategory(5, 7),
                new ProductCategory(6, 6),
                new ProductCategory(7, 3),
                new ProductCategory(7, 4),
                new ProductCategory(8, 1),
                new ProductCategory(8, 7),
                new ProductCategory(9, 2),
                new ProductCategory(9, 6),
                new ProductCategory(10, 2),
                new ProductCategory(10, 4),
                new ProductCategory(11, 2),
                new ProductCategory(11, 3),
                new ProductCategory(11, 7),
            });
        }
    }
}
