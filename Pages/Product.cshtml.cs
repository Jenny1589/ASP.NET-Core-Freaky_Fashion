using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion
{
    public class ProductModel : PageModel
    {
        private FreakyFashionContext _context;
        public Product Product { get; private set; }

        public ProductModel(FreakyFashionContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(string urlSlug)
        {
            Product = _context.Products
                .FirstOrDefault(p => p.UrlSlug.Equals(urlSlug.ToLower()));

            if (Product == null) return NotFound();

            return Page();
        }

        public IActionResult OnPost(int productId)
        {
            var serializedCart = HttpContext.Session.GetString("Cart");

            var cart = JsonConvert.DeserializeObject<Cart>(serializedCart);

            Product = _context.Products
                .FirstOrDefault(p => p.Id == productId);

            cart.Add(Product);

            serializedCart = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("Cart", serializedCart);

            return RedirectToPage();
        }
    }
}