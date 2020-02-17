using Newtonsoft.Json;

namespace FreakyFashion.Data.Entities
{
    public class OrderItem
    {
        public Product Product { get; protected set; }
        public uint Count { get; protected set; } = 1;
        public double Cost
        {
            get
            {
                return Count * Product.Price;
            }
        }

        public OrderItem(Product product)
        {
            Product = product;
        }

        [JsonConstructor]
        public OrderItem(Product product, uint count)
            :this(product)
        {
            Count = count;
        }

        public void Add()
        {
            Count++;
        }

        public void Remove()
        {
            Count--;
        }
    }
}
