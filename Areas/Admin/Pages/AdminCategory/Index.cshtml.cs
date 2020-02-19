using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FreakyFashion.Data.Entities;

namespace FreakyFashion.Areas.Admin.AdminCategory
{
    public class IndexModel : PageModel
    {
        private readonly FreakyFashion.Data.FreakyFashionContext _context;

        public IndexModel(FreakyFashion.Data.FreakyFashionContext context)
        {
            _context = context;
        }

        public IList<Category> CategoryList { get;set; }

        public async Task OnGetAsync()
        {
            CategoryList = await _context.Categories
                .Include(c => c.ProductCategories)
                .ToListAsync();
        }
    }
}
