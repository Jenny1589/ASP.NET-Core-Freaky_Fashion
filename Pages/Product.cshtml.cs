using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

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

        public void OnGet(int id)
        {
            Product = _context.Products.Find(id);
            ViewData["CategoryList"] = _context.Categories.ToList();
        }
    }
}