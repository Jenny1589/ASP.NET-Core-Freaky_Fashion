using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion
{
    public class ProductModel : PageModel
    {
        private FreakyFashionContext _context;
        public Product Product { get; private set; }
        public List<Product> RecommendedProductList { get; set; }

        public ProductModel(FreakyFashionContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(string urlSlug)
        {
            Product = _context.Products
                .FirstOrDefault(p => p.UrlSlug.Equals(urlSlug.ToLower()));

            if (Product == null) return NotFound();


            ViewData["CategoryList"] = _context.Categories.ToList();
            RecommendedProductList = _context.Products.Where(p => !p.Equals(Product)).Take(4).ToList();

            return Page();
        }
    }
}