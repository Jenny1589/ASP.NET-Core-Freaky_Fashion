using Newtonsoft.Json;

namespace FreakyFashion.Data.Entities
{
    public class OrderItem
    {
        public int Id { get; protected set; }
        public Product Product { get; set; }
        public uint Count { get; protected set; } = 1;
        public double Cost
        {
            get
            {
                return Count * Product.Price;
            }
        }

        public int OrderId { get; protected set; }
        public Order Order { get; protected set; }

        protected OrderItem()
        {}

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
