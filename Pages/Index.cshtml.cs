using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FreakyFashion.Pages
{
    public class IndexModel : PageModel
    {
        private FreakyFashionContext _context;

        public List<Product> ProductList { get; private set; }
        public List<Category> CategoryList { get; private set; }

        public IndexModel(FreakyFashionContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            ProductList = await _context.Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .ToListAsync();

            CategoryList = await _context.Categories
                .Where(c => c.IsHighlighted)
                .ToListAsync();

            return Page();
        }
    }
}
