using System;
using System.Collections.Generic;

namespace FreakyFashion.Data.Entities
{
    public class Category : WebEntity
    {
        public Uri ImageUri { get; protected set; }
        public bool IsHighlighted { get; protected set; }
        public List<ProductCategory> ProductCategories { get; protected set; }

        public Category(int id, string name, Uri imageUri, bool isHighlighted)
            : base(id, name)
        {
            ImageUri = imageUri;
            IsHighlighted = isHighlighted;
        }
    }
}
