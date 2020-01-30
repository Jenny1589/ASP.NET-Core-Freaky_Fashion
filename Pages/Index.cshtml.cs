using System;
using System.Collections.Generic;
using System.Linq;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FreakyFashion.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private FreakyFashionContext _context;

        public List<Product> ProductList { get; private set; }
        public List<Category> CategoryList { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, FreakyFashionContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            ProductList = _context.Products.ToList();
            CategoryList = _context.Categories.ToList();
            ViewData["CategoryList"] = CategoryList;
        }
    }
}
