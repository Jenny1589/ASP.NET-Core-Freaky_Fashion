using System.Collections.Generic;
using System.Linq;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion
{
    public class CategoryModel : PageModel
    {
        private FreakyFashionContext _context;

        public Category Category { get; private set; }
        public List<Product> ProductList { get; private set; }

        public CategoryModel(FreakyFashionContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        { 
            Category = _context.Categories
                .Include(c => c.ProductCategories)
                .ThenInclude(pc => pc.Product)
                .FirstOrDefault(c => c.Id == id);

            ProductList = Category?.ProductCategories
                .Select(pc => pc.Product)
                .ToList();

            ViewData["CategoryList"] = _context.Categories.ToList();
        }
    }
}