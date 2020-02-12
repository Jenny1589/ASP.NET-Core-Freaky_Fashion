using System;
using System.Collections.Generic;
using System.Linq;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
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

        public void OnGet()
        {
            ProductList = _context.Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .ToList();

            CategoryList = _context.Categories.ToList();
        }
    }
}
