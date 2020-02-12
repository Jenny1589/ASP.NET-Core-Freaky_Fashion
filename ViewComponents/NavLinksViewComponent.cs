using FreakyFashion.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion.ViewComponents
{
    public class NavLinksViewComponent : ViewComponent
    {
        private FreakyFashionContext _context;

        public NavLinksViewComponent(FreakyFashionContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(bool isFooter)
        {
            var categories = await _context.Categories.ToListAsync();

            if (!isFooter)
            {
                return View("Header", categories);
            }

            return View("Footer", categories);
        }
    }
}
