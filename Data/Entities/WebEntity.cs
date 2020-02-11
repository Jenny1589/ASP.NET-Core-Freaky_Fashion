using System;

namespace FreakyFashion.Data.Entities
{
    public abstract class WebEntity
    {
        public int Id { get; protected set; }

        private string _name;
        public string Name
        {
            get { return _name; }

            protected set
            {
                _name = value;

                UrlSlug = _name
                    .Replace(' ', '-')
                    .ToLower() + $"-{Guid.NewGuid()}";
            }
        }

        public string UrlSlug { get; protected set; }

        public WebEntity(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
