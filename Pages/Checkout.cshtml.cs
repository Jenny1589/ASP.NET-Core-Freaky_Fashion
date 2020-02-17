using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FreakyFashion
{
    public class CheckoutModel : PageModel
    {
        public Cart Cart { get; private set; }

        public void OnGet()
        {
            Cart = JsonConvert.DeserializeObject<Cart>(HttpContext.Session.GetString("Cart"));
        }
    }
}