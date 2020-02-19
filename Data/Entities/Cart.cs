using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion.Data.Entities
{
    public class Cart
    {
        private List<OrderItem> orderItems = new List<OrderItem>();
        private double totalCost;

        public int Count
        {
            get
            {
                return orderItems.Count();
            }
        }

        public double TotalCost
        {
            get 
            {
                totalCost = 0;

                foreach(var orderItem in orderItems)
                {
                    totalCost += orderItem.Cost;
                }

                return totalCost; 
            }
        }

        public IEnumerable<OrderItem> CartContent
        {
            get
            {
                return orderItems;
            }
        }

        [JsonConstructor]
        public Cart(OrderItem[] cartContent)
        {
            if(cartContent != null)
            {
                foreach(var orderItem in cartContent)
                {
                    orderItems.Add(orderItem);
                }
            }
        }

        public void Empty()
        {
            orderItems = new List<OrderItem>();
        }

        public void Add(Product product)
        {
            var oi = orderItems.FirstOrDefault(i => i.Product.Id.Equals(product.Id));
            
            if(oi == null)
            {
                orderItems.Add(new OrderItem(product));
            }
            else
            {
                oi.Add();
            }
        }                  
    }
}
