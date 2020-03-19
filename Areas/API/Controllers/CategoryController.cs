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

        /// <summary>
        /// Get all categories.
        /// </summary>
        /// <returns>A collection of all categories</returns>
        /// <response code="200">Returns a collection of all categories</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        /// <summary>
        /// Gets category with specified id.
        /// </summary>
        /// <param name="id">Id of category to fetch</param>
        /// <returns>Returns category with given id</returns>
        /// <response code="200">Returns the category with the id</response>
        /// <response code="404">If no category exist with this id</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Category> GetCategory([FromRoute]int id)
        {
            var category = _context.Categories
                .FirstOrDefault(c => c.Id == id);

            if (category == null) return NotFound();

            return category;
        }

        /// <summary>
        /// Adds a new category
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Category
        ///     {
        ///         "id": 1,
        ///         "name": "category name",
        ///         "imageUri": "/img/file.jpg"
        ///     }
        ///     
        /// </remarks>
        /// <param name="category">The category to add</param>
        /// <returns>The created category together with the path</returns>
        /// <response code="201">Returns the newly created category</response>
        [Authorize]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult AddCategory([FromBody]Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();

            return Created($"/api/category/{category.Id}", category);
        }


        /// <summary>
        /// Deletes the category with specified id.
        /// </summary>
        /// <param name="id">Id of the category to delete</param>
        /// <returns>The deleted category</returns>
        /// <response code="200">Returns the deleted category</response>
        /// <response code="404">If no category exist with this id</response>
        [Authorize]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Category> DeleteCategory([FromRoute]int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);

            if (category == null) return NotFound();

            _context.Categories.Remove(category);
            _context.SaveChanges();

            return category;
        }

        /// <summary>
        /// Update category data.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///    
        ///     POST api/Category/{id}
        ///     [
        ///         {
        ///             "op": "replace"
        ///             "path": "/Name"
        ///             "value": "New name"
        ///         }
        ///     ]
        ///     
        /// </remarks>
        /// <param name="id">Id of the category to update</param>
        /// <param name="patches">Body containing information to change</param>
        /// <returns>Returns a status code indicating success or failiure</returns>
        /// <response code="204">If category was successfully updated.</response>
        /// <response code="404">If category with given id does not exist</response>
        [Authorize("IsAdministrator")]
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateProduct(int id, [FromBody]JsonPatchDocument<Category> patches)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);

            if (category == null) return NotFound();

            patches.ApplyTo(category);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
