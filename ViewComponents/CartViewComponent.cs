using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {

        
        public IViewComponentResult Invoke()
        {
            var serializedCart = HttpContext.Session.GetString("Cart");

            Cart cart;

            if (string.IsNullOrEmpty(serializedCart))
            {
                cart = new Cart(null);
                serializedCart = JsonConvert.SerializeObject(cart);
                HttpContext.Session.SetString("Cart", serializedCart);
            }
            else
            {
                cart = JsonConvert.DeserializeObject<Cart>(serializedCart);
            }
            
            return View(cart);

        }
    }
}
