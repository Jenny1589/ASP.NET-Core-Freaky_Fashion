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

            builder.HasData(new Product[] {
                new Product(id: 1,
                            name: "Crazy skirt",
                            description: "Do you want to be the one to stand out in a crowd? " +
                                         "This skirt will fit for any occasion",
                            price: 499.9,
                            imageUri: new Uri(uriString: "/img/product_01.jpg", 
                                              uriKind: UriKind.Relative)),

                new Product(id: 2,
                            name: "Wild pants",
                            description: "These pants will certainly get you the attention you deserve. " +
                                         "Be brave, be free, be wild",
                            price: 899.9,
                            imageUri: new Uri(uriString: "/img/product_02.jpg", 
                                              uriKind: UriKind.Relative)),

                new Product(id: 3,
                            name: "Furry coatee",
                            description: "This jacket will keep you both warm and dazzling. " +
                                         "It comes in many vibrant colours. What is your furry?",
                            price: 1299.9,
                            imageUri: new Uri(uriString: "/img/product_03.jpg",
                                              uriKind: UriKind.Relative)),
            });
        }
    }
}
