using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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


        /// <summary>
        /// Adds a product to a category
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ProductCategory
        ///     
        ///     {
        ///         "productId": 2,
        ///         "categoryId": 5
        ///     }
        ///     
        /// </remarks>
        /// <param name="productCategory">Body containing id of product and id of the category.</param>
        /// <returns>The combination of product and category id</returns>
        /// <response code="201">Returns the id's of the product and category that has been combinated</response>
        /// <response code="404">If category or product could not be found</response>
        [Authorize]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult AddProductToCategory([FromBody]ProductCategory productCategory)
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
