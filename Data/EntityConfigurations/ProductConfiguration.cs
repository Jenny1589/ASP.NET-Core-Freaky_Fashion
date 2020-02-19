using FreakyFashion.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FreakyFashion.Data.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Description)
                .IsRequired();

            builder.Property(p => p.ImageUri)
                .HasConversion(value => value.ToString(), value => new Uri(value, UriKind.Relative))
                .IsRequired();

            builder.Property(p => p.UrlSlug)
                .IsRequired();

            builder.HasData(
                new Product[]
                {
                    new Product(
                        id: 1,
                        articleNumber: "1234-5678",
                        name: "Campaign Blouse",
                        description: "Something must exist in this freaky business! Buy it... NOW!",
                        price: 895.0,
                        imageUri: new Uri("/img/blouse_01.jpg", UriKind.Relative),
                        urlSlug: "campaign-blouse-6d544e5c-a32b-4130-877f-94b13040ff92"),

                    new Product(
                        id: 2,
                        articleNumber: "9876-5432",
                        name: "Freaky Jeans",
                        description: "This is Freaky Fashion isn't it? Of course it is. Bring out your Freaky!",
                        price: 245.0,
                        imageUri: new Uri("/img/jeans_03.jpg", UriKind.Relative),
                        urlSlug: "freaky-jeans-6d544e5c-a32b-4130-877f-94b13040ff92"),

                    new Product(
                        id: 3,
                        articleNumber: "8765-4321",
                        name: "Bad Girl Shirt",
                        description: "You are a bad girl aren't you? Of course you are. Dare you to show it off!",
                        price: 895.0,
                        imageUri: new Uri("/img/shirt_01.jpg", UriKind.Relative),
                        urlSlug: "bad-girl-shirt-6d544e5c-a32b-4130-877f-94b13040ff92"),

                    new Product(
                        id: 4,
                        articleNumber: "2345-6789",
                        name: "Smokin Dress",
                        description: "Really elegant and posh. Fits for the everyday stand out look or for the next party",
                        price: 999.0,
                        imageUri: new Uri("/img/dress_03.jpg", UriKind.Relative),
                        urlSlug: "smokin-dress-6d544e5c-a32b-4130-877f-94b13040ff92"),

                    new Product(
                        id: 5,
                        articleNumber: "3456-7890",
                        name: "Pretty Freaky Jeans",
                        description: "Every freaky girl must have a pair of jeans in their closet.",
                        price: 799.0,
                        imageUri: new Uri("/img/jeans_01.jpg", UriKind.Relative),
                        urlSlug: "pretty-freaky-jeans-6d544e5c-a32b-4130-877f-94b13040ff92"),

                    new Product(
                        id: 6,
                        articleNumber: "4321-8765",
                        name: "Beach Dress",
                        description: "Own the beach this summer? Of course you want! Pro tip: Buy this dress and work it along the shore",
                        price: 390.0,
                        imageUri: new Uri("/img/dress_02.jpg", UriKind.Relative),
                        urlSlug: "beach-dress-6d544e5c-a32b-4130-877f-94b13040ff92"),

                    new Product(
                        id: 7,
                        articleNumber: "3210-5678",
                        name: "Furry Blouse",
                        description: "Do you feel like an animal? This freaky blouse comes in many vibrant colours. Pick your furry!",
                        price: 469.0,
                        imageUri: new Uri("/img/blouse_03.jpg", UriKind.Relative),
                        urlSlug: "furry-blouse-6d544e5c-a32b-4130-877f-94b13040ff92"),

                    new Product(
                        id: 8,
                        articleNumber: "4321-5678",
                        name: "Pepsi Shirt",
                        description: "Are you a Pepsi fan like us? Then you just can't be without this shirt...",
                        price: 89.0,
                        imageUri: new Uri("/img/shirt_02.jpg", UriKind.Relative),
                        urlSlug: "pepsi-shirt-6d544e5c-a32b-4130-877f-94b13040ff92")
                });


        }
    }
}
