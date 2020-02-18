using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FreakyFashion.ViewComponents
{
    public class SignOutViewComponent : ViewComponent
    {

        private readonly SignInManager<FreakyFashionUser> _signInManager;

        public SignOutViewComponent(SignInManager<FreakyFashionUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IViewComponentResult Invoke()
        {
            if (_signInManager.IsSignedIn(HttpContext.User))
            {
                return View();
            }

            return Content(string.Empty);
        }
    }
}
