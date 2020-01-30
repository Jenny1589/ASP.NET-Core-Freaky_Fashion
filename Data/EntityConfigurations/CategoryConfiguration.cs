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

            builder.HasData(new Category[]
            {
                new Category(id: 1,
                             name: "Campaign",
                             imageUri: new Uri("/img/campaign.jpg", UriKind.Relative),
                             isHighlighted: true),
                new Category(id: 2,
                             name: "News",
                             imageUri: new Uri("/img/news.jpg", UriKind.Relative),
                             isHighlighted: true),
                new Category(id: 3,
                             name: "Spring",
                             imageUri: new Uri("/img/spring.jpg", UriKind.Relative),
                             isHighlighted: true),
                new Category(id: 4,
                             name: "Shirts",
                             imageUri: new Uri("/img/shirt_01.jpg", UriKind.Relative),
                             isHighlighted: false),
                new Category(id: 5,
                             name: "Blouses",
                             imageUri: new Uri("/img/blouse_01.jpg", UriKind.Relative),
                             isHighlighted: false),
                new Category(id: 6,
                             name: "Jeans",
                             imageUri: new Uri("/img/jeans_01.jpg", UriKind.Relative),
                             isHighlighted: false),
                new Category(id: 7,
                             name: "Dresses",
                             imageUri: new Uri("/img/dress_01.jpg", UriKind.Relative),
                             isHighlighted: false)
            });
        }
    }
}
