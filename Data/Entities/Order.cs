using System.Collections.Generic;

namespace FreakyFashion.Data.Entities
{
    public class Order
    {
        public int Id { get; protected set; }

        public string CustomerId { get; protected set; }
        public FreakyFashionUser Customer { get; protected set; }

        public IEnumerable<OrderItem> OrderContent { get; protected set; }

        protected Order()
        {}
        
        public Order(IEnumerable<OrderItem> orderContent, FreakyFashionUser customer)
        {
            Customer = customer;
            OrderContent = orderContent;
        }
    }    
}
