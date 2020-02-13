using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;

namespace FreakyFashion.Areas.Admin.AdminProduct
{
    public class IndexModel : PageModel
    {
        private readonly FreakyFashion.Data.FreakyFashionContext _context;

        public IndexModel(FreakyFashion.Data.FreakyFashionContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
