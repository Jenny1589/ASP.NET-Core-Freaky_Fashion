using FreakyFashion.Data;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FreakyFashion.ViewComponents
{
    public class RecommendedProductsViewComponent : ViewComponent
    {
        private readonly FreakyFashionContext _context;

        public RecommendedProductsViewComponent(FreakyFashionContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(Product current)
        {
            var recommendedProductList = _context.Products.Where(p => !p.Equals(current)).Take(4).ToList();

            return View(recommendedProductList);
        }
        
    }
}
