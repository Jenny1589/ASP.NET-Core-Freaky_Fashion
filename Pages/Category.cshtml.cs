using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IActionResult> OnGetAsync(string urlSlug)
        { 
            Category = await _context.Categories
                .Include(c => c.ProductCategories)
                .ThenInclude(pc => pc.Product)
                .FirstOrDefaultAsync(c => c.UrlSlug.Equals(urlSlug));

            if (Category == null) return NotFound();

            ProductList = Category.ProductCategories
                .Select(pc => pc.Product)
                .ToList();

            ViewData["CategoryList"] = _context.Categories.ToList();

            return Page();
        }
    }
}