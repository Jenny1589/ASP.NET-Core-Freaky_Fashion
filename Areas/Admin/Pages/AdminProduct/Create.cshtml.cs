using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FreakyFashion.Areas.Admin.AdminProduct
{
    public class CreateModel : PageModel
    {
        private readonly FreakyFashion.Data.FreakyFashionContext _context;

        [BindProperty]
        public FormModel ProductModel { get; set; } = new FormModel();

        [BindProperty]
        public List<int> CategoryId { get; set; }

        public List<Category> CategoryList { get; set; } = new List<Category>();

        public CreateModel(FreakyFashion.Data.FreakyFashionContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            CategoryList = await _context.Categories.ToListAsync();

            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var product = new Product(ProductModel.ArticleNumber,
                ProductModel.ProductName,
                ProductModel.Description,
                ProductModel.Price,
                ProductModel.ImageUri);

            _context.Products.Add(product);
            _context.SaveChanges();

            product = _context.Products.FirstOrDefault(p => p.ImageUri.Equals(product.ImageUri));

            foreach (var categoryID in CategoryId)
            {
                product.ProductCategories.Add(new ProductCategory(categoryID));
            }

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }


        public class FormModel
        {
            [Required]
            [Display(Name = "Art.Nr")]
            public string ArticleNumber { get; set; }

            [Required]
            [Display(Name = "Name")]
            public string ProductName { get; set; }

            [Required]
            public double Price { get; set; }
            public string Description { get; set; }

            [Display(Name = "Image path")]
            public Uri ImageUri { get; set; }
        }
    }
}
