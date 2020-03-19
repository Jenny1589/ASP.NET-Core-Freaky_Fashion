using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace FreakyFashion.Areas.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly FreakyFashionContext _context;

        public ProductController(FreakyFashionContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets a collection of all products.
        /// </summary>
        /// <returns>A collection of all products</returns>
        /// <response code="200">Returns a collection of all products.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        /// <summary>
        /// Gets a single product.
        /// </summary>
        /// <param name="id">The id of the product to fetch</param>
        /// <returns>The requested product</returns>
        /// <response code="200">Returns the product with given id</response>
        /// <response code="404">If product with given id does not exist</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Product> GetProduct([FromRoute]int id)
        {
            var product = _context.Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .FirstOrDefault(p => p.Id == id);

            if (product == null) return NotFound();

            return product;
        }

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     
        ///     POST api/Product
        ///     {
        ///         "id": 4,
        ///         "articleNumber": "1234-PROD"
        ///         "name": "Product name",
        ///         "description": "Product description"
        ///         "price": 123.0,
        ///         "imageUri": "/img/productImg.jpg"
        ///     }
        ///     
        /// </remarks>
        /// <param name="product">Product to create</param>
        /// <returns>The newly created product</returns>
        /// <response code="201">Returns the newly created product</response>
        [Authorize("IsAdministrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult AddProduct([FromBody]Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return Created($"/api/product/{product.Id}", product);
        }

        /// <summary>
        /// Deletes a product
        /// </summary>
        /// <param name="id">Id of product to delete</param>
        /// <returns>The deleted product</returns>
        /// <response code="200">Returns the deleted product</response>
        /// <response code="404">Product with given id does not exist</response>
        [Authorize("IsAdministrator")]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Product> DeleteProduct([FromRoute] int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null) return NotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();

            return product;
        }

        /// <summary>
        /// Update product data.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///    
        ///     POST api/Product/{id}
        ///     [
        ///         {
        ///             "op": "replace"
        ///             "path": "/Price"
        ///             "value": 123.0
        ///         }
        ///     ]
        ///     
        /// </remarks>
        /// <param name="id">Id of the product to update</param>
        /// <param name="patches">Body containing information to change</param>
        /// <returns>Returns a status code indicating success or failiure</returns>
        /// <response code="204">If product was successfully updated.</response>
        /// <response code="404">If product with given id does not exist</response>
        [Authorize("IsAdministrator")]
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateProduct(int id, [FromBody]JsonPatchDocument<Product> patches)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null) return NotFound();

            patches.ApplyTo(product);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
