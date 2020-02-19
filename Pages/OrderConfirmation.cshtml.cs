using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
            Order = _context.Orders.FirstOrDefault(o => o.OrderGuid.ToString() == orderGuid);
        }
    }
}