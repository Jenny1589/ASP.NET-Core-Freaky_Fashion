using System.Linq;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion
{
    public class OrderConfirmationModel : PageModel
    {
        private readonly FreakyFashionContext _context;

        public Order Order { get; private set; }

        public OrderConfirmationModel(FreakyFashionContext context)
        {
            _context = context;
        }

        public void OnGet(string orderGuid)
        {
            Order = _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderContent)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefault(o => o.OrderGuid.ToString() == orderGuid);
        }
    }
}