using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FreakyFashion.Areas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly FreakyFashionContext _context;

        public CategoryController(FreakyFashionContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Category> GetCategory(int id)
        {
            var category = _context.Categories
                .FirstOrDefault(c => c.Id == id);

            if (category == null) return NotFound();

            return category;
        }
    }
}
