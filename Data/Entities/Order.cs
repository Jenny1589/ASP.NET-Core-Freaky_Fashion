using System;
using System.Collections.Generic;

namespace FreakyFashion.Data.Entities
{
    public class Order
    {
        public int Id { get; protected set; }
        public DateTime OrderTime { get; set; }

        public int CustomerId { get; protected set; }
        public Customer Customer { get; protected set; }
        public Guid OrderGuid { get; protected set; }

        public IEnumerable<OrderItem> OrderContent { get; protected set; }

        protected Order()
        {}
        
        public Order(IEnumerable<OrderItem> orderContent, Customer customer)
        {
            Customer = customer;
            OrderContent = orderContent;
            OrderTime = DateTime.Now;
            OrderGuid = Guid.NewGuid();
        }
    }    
}
