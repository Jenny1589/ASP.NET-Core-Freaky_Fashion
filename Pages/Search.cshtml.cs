using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;

namespace FreakyFashion
{
    public class SearchModel : PageModel
    {
        private readonly FreakyFashionContext _context;

        public string Query { get; private set; }

        public SearchModel(FreakyFashionContext context)
        {
            _context = context;
        }

        public IList<Product> SearchResult { get;set; }

        public async Task OnGetAsync(string query)
        {
            Query = query;

            SearchResult = await _context.Products
                .Where(p => p.Name.ToUpper().Contains(query.ToUpper()))
                .ToListAsync();
        }
    }
}
