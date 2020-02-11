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

            builder.HasData(new Product[] {
                new Product(id: 1,
                            articleNumber: "12345-6789",
                            name: "Crazy skirt",
                            description: "Do you want to be the one to stand out in a crowd? " +
                                         "This skirt will fit for any occasion",
                            price: 499.9,
                            imageUri: new Uri(uriString: "/img/product_01.jpg",
                                              uriKind: UriKind.Relative)),

                new Product(id: 2,
                            articleNumber: "98765-4321",
                            name: "Wild pants",
                            description: "These pants will certainly get you the attention you deserve. " +
                                         "Be brave, be free, be wild",
                            price: 899.9,
                            imageUri: new Uri(uriString: "/img/product_02.jpg", 
                                              uriKind: UriKind.Relative)),

                new Product(id: 3,
                            articleNumber: "21543-9876",
                            name: "Furry coatee",
                            description: "This jacket will keep you both warm and dazzling. " +
                                         "It comes in many vibrant colours. What is your furry?",
                            price: 1299.9,
                            imageUri: new Uri(uriString: "/img/product_03.jpg",
                                              uriKind: UriKind.Relative)),

                new Product(id: 4,
                            articleNumber: "32145-8769",
                            name: "Gorgeous blouse",
                            description: "You will be the center of all attention, 100% guarantee!" +
                                         "Gorgeous will bring out your freaky. Get ready to party!",
                            price: 349.95,
                            imageUri: new Uri(uriString: "/img/blouse_01.jpg",
                                              uriKind: UriKind.Relative)),

                new Product(id: 5,
                            articleNumber: "42137-2897",
                            name: "Green flower dress",
                            description: "This is deffinately THE dress." +
                                         "You will see shapes you didn't know you had.",
                            price: 3599.9,
                            imageUri: new Uri(uriString: "/img/dress_01.jpg",
                                              uriKind: UriKind.Relative)),

                new Product(id: 6,
                            articleNumber: "67921-5690",
                            name: "Cool jeans",
                            description: "Too cool for school? Get theese jeans today!",
                            price: 699,
                            imageUri: new Uri(uriString: "/img/jeans_01.jpg",
                                              uriKind: UriKind.Relative)),

                new Product(id: 7,
                            articleNumber: "75641-0876",
                            name: "Bad girl shirt",
                            description: "You feel bad? No you are just freaky!" +
                                         "Show the real you.",
                            price: 295,
                            imageUri: new Uri(uriString: "/img/shirt_01.jpg",
                                              uriKind: UriKind.Relative)),
                new Product(id: 8,
                            articleNumber: "29064-8514",
                            name: "Freaky beach dress",
                            description: "Own the beach this summer? Of course you want" +
                                         "What are you waiting for?",
                            price: 595,
                            imageUri: new Uri(uriString: "/img/dress_02.jpg",
                                              uriKind: UriKind.Relative)),

                new Product(id: 9,
                            articleNumber: "85201-6354",
                            name: "Get dirty jeans",
                            description: "Casual, comfortable, enjoyable!" +
                                         "No need to get stiff in theese pants",
                            price: 899,
                            imageUri: new Uri(uriString: "/img/jeans_02.jpg",
                                              uriKind: UriKind.Relative)),
                new Product(id: 10,
                            articleNumber: "50945-3165",
                            name: "Pepsi Cola shirt",
                            description: "Are you a Pepsi fan? Show it to the world!",
                            price: 99,
                            imageUri: new Uri(uriString: "/img/shirt_02.jpg",
                                              uriKind: UriKind.Relative)),
                new Product(id: 11,
                            articleNumber: "20975-8647",
                            name: "Smokin' dress",
                            description: "Elegant, beautiful, yes just gorgeous - Or as we say: Smokin'",
                            price: 1999.99,
                            imageUri: new Uri(uriString: "/img/dress_03.jpg",
                                              uriKind: UriKind.Relative)),
            });
        }
    }
}
