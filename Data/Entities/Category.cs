using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FreakyFashion.Data.Entities
{
    public class Category : WebEntity
    {
        public Uri ImageUri { get; protected set; }
        public bool IsHighlighted { get; protected set; }
        public List<ProductCategory> ProductCategories { get; protected set; }

        [JsonConstructor]
        public Category(int id, string name, Uri imageUri, bool isHighlighted, string urlSlug)
            : this(name, imageUri, isHighlighted)
        {
            Id = id;
            _name = name;
            UrlSlug = urlSlug;
        }

        public Category(string name, Uri imageUri, bool isHighlighted)
            :base(name)
        {
            ImageUri = imageUri;
            IsHighlighted = isHighlighted;
        }
    }
}
