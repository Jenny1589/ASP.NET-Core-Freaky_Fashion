using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FreakyFashion.Data.Entities;

namespace FreakyFashion
{
    public class IndexModel : PageModel
    {
        private readonly FreakyFashion.Data.FreakyFashionContext _context;

        public IndexModel(FreakyFashion.Data.FreakyFashionContext context)
        {
            _context = context;
        }

        public IList<Order> OrderList { get;set; }

        public async Task OnGetAsync()
        {
            OrderList = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderContent)
                .ThenInclude(oi => oi.Product)
                .ToListAsync();
        }
    }
}
