using System;

namespace FreakyFashion.Data.Entities
{
    public class Product
    {
        public int Id { get; protected set; }
        public string ArticleNumber { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public double Price { get; protected set; }
        public Uri ImageUri { get; protected set; }

        public Product(string articleNumber, string name, string description, double price, Uri imageUri)
        {
            ArticleNumber = articleNumber;
            Name = name;
            Description = description;
            Price = price;
            ImageUri = imageUri;
        }

        public Product(int id, string articleNumber, string name, string description, double price, Uri imageUri)
            : this(articleNumber, name, description, price, imageUri)
        {
            Id = id;
        }
    }
}
