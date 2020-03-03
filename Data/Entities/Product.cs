using Newtonsoft.Json;
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

        [JsonConstructor]
        public Product(int id, string articleNumber, string name, string description, double price, Uri imageUri, string urlSlug)
            : this(articleNumber, name, description, price, imageUri)
        {
            Id = id;
            _name = name;
            UrlSlug = urlSlug;
        }

        public Product(string articleNumber, string name, string description, double price, Uri imageUri)
            : base(name)
        {
            ArticleNumber = articleNumber;
            Description = description;
            Price = price;
            ImageUri = imageUri;
        }

        internal object Include()
        {
            throw new NotImplementedException();
        }
    }
}
