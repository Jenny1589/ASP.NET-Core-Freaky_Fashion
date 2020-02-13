using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreakyFashion.Data.Entities
{
    public class Product : WebEntity
    {
        [Display(Name = "Art.nr.")]
        public string ArticleNumber { get; protected set; }
        public string Description { get; protected set; }
        public double Price { get; protected set; }
        public Uri ImageUri { get; protected set; }
        public List<ProductCategory> ProductCategories { get; protected set; }

        public Product(int id, string articleNumber, string name, string description, double price, Uri imageUri)
            : base(id, name)
        {
            ArticleNumber = articleNumber;
            Description = description;
            Price = price;
            ImageUri = imageUri;
        }
    }
}
