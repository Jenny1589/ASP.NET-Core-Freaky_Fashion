using System;

namespace FreakyFashion.Data.Entities
{
    public class Category
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public Uri ImageUri { get; protected set; }
        public bool IsHighlighted { get; protected set; }

        public Category(int id, string name, Uri imageUri, bool isHighlighted)
        {
            Id = id;
            Name = name;
            ImageUri = imageUri;
            IsHighlighted = isHighlighted;
        }
    }
}
