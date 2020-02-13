using Microsoft.AspNetCore.Mvc;

namespace FreakyFashion.ViewComponents
{
    public class AdminNavViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (HttpContext.User.IsInRole("Administrator"))
            {
                return View();
            }

            return Content(string.Empty);
        }
    }
}
