using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FreakyFashion.Areas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductCategoryController : ControllerBase
    {
        private readonly FreakyFashionContext _context;

        public ProductCategoryController(FreakyFashionContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult AddCategory(ProductCategory productCategory)
        {
            var category = _context.Categories
                .Include(c => c.ProductCategories)
                .FirstOrDefault(c => c.Id == productCategory.CategoryId);

            var product = _context.Products.FirstOrDefault(p => p.Id == productCategory.ProductId);

            if (category == null) return NotFound();
            if (product == null) return NotFound();

            category.ProductCategories.Add(productCategory);
            _context.SaveChanges();

            return Created($"/api/productcategory/{productCategory.CategoryId}-{productCategory.ProductId}", productCategory);
        }
    }
}
