using FreakyFashion.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FreakyFashion.Data.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.Property(c => c.Name)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.ImageUri)
                .HasConversion(value => value.ToString(), value => new Uri(value, UriKind.Relative))
                .IsRequired();
        }
    }
}
