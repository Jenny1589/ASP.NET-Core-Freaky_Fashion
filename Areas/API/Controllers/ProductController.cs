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
    public class ProductController : ControllerBase
    {
        private readonly FreakyFashionContext _context;

        public ProductController(FreakyFashionContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _context.Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .FirstOrDefault(p => p.Id == id);

            if (product == null) return NotFound();

            return product;
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return Created($"/api/product/{product.Id}", product);
        }
    }
}
