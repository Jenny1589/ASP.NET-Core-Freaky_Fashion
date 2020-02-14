using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreakyFashion.Data.Entities
{
    public class Product : WebEntity
    {
        public string ArticleNumber { get; protected set; }

        public string Description { get; protected set; }
        public double Price { get; protected set; }

        public Uri ImageUri { get; protected set; }
        public List<ProductCategory> ProductCategories { get; protected set; } = new List<ProductCategory>();

        public Product(int id, string articleNumber, string name, string description, double price, Uri imageUri)
            : this(articleNumber, name, description, price, imageUri)
        {
            Id = id;
        }

        public Product(string articleNumber, string name, string description, double price, Uri imageUri)
            : base(name)
        {
            ArticleNumber = articleNumber;
            Description = description;
            Price = price;
            ImageUri = imageUri;
        }
    }
}
