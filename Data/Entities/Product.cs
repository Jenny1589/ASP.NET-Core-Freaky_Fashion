using System;
using System.Collections.Generic;

namespace FreakyFashion.Data.Entities
{
    public class Product
    {
        public int Id { get; protected set; }
        public string ArticleNumber { get; protected set; }


        private string _name;
        public string Name
        {
            get { return _name; }
            protected set
            {
                _name = value;

                UrlSlug = _name
                    .Replace(' ', '-')
                    .ToLower() + $"-{Id}";
            }
        }

        public string Description { get; protected set; }
        public double Price { get; protected set; }
        public Uri ImageUri { get; protected set; }
        public string UrlSlug { get; protected set; }
        public List<ProductCategory> ProductCategories { get; protected set; }

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
