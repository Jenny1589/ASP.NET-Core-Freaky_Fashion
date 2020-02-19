using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace FreakyFashion.Areas.Admin.AdminCategory
{
    public class CreateModel : PageModel
    {
        private static FreakyFashionContext _context;

        public CreateModel(FreakyFashionContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(string message)
        {
            return Page();
        }

        [BindProperty]
        public FormModel CategoryModel { get; set; } = new FormModel();

        public string Message { get; private set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Category category = null;

            if(CategoryModel.IsHighlighted && _context.Categories.Where(c => c.IsHighlighted).Count() == 3)
            {
                category = new Category(CategoryModel.Name, CategoryModel.ImageUri, false);
            }
            else
            {
                category = new Category(CategoryModel.Name, CategoryModel.ImageUri, CategoryModel.IsHighlighted);
            }

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public class FormModel
        {
            [Required]
            public string Name { get; set; }

            [Display(Name = "Highlight this category")]
            public bool IsHighlighted { get; set; }

            [Display(Name = "Image path")]
            public Uri ImageUri { get; set; }
        }
    }
}
