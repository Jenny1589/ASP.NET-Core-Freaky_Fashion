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
                             isHighlighted: true,
                             urlSlug: "campaign-d87fd666-0bc1-49c4-9aae-7378aa3476ef"),
                new Category(id: 2,
                             name: "News",
                             imageUri: new Uri("/img/news.jpg", UriKind.Relative),
                             isHighlighted: true,
                             urlSlug: "news-d8ceb934-a053-4528-be14-62270f6555bd"),
                new Category(id: 3,
                             name: "Spring",
                             imageUri: new Uri("/img/spring.jpg", UriKind.Relative),
                             isHighlighted: true,
                             urlSlug: "spring-8fa53587-3f40-4431-a267-93202954cecb"),
                new Category(id: 4,
                             name: "Shirts",
                             imageUri: new Uri("/img/shirt_01.jpg", UriKind.Relative),
                             isHighlighted: false,
                             urlSlug: "shirts-18b27c8b-10d0-4bc6-81cf-6345bc215868"),
                new Category(id: 5,
                             name: "Blouses",
                             imageUri: new Uri("/img/blouse_01.jpg", UriKind.Relative),
                             isHighlighted: false,
                             urlSlug: "blouses-6ef1ae86-f4c0-42b8-b183-db5831181cf7"),
                new Category(id: 6,
                             name: "Jeans",
                             imageUri: new Uri("/img/jeans_01.jpg", UriKind.Relative),
                             isHighlighted: false,
                             urlSlug: "jeans-c038d230-d071-48d8-a005-644070e4b2e5"),
                new Category(id: 7,
                             name: "Dresses",
                             imageUri: new Uri("/img/dress_01.jpg", UriKind.Relative),
                             isHighlighted: false,
                             urlSlug: "dresses-197fb20e-14e5-4a06-8fba-f0ddd97d47df")
            });
        }
    }
}
