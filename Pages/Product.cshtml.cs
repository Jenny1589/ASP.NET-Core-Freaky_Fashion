using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

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

        public void OnGet(int id)
        {
            Product = _context.Products.Find(id);
            ViewData["CategoryList"] = _context.Categories.ToList();

            RecommendedProductList = _context.Products.Where(p => !p.Equals(Product)).Take(4).ToList();
        }
    }
}