using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion.ViewComponents
{
    public class AccountIconsViewComponent : ViewComponent
    {
        private readonly UserManager<FreakyFashionUser> _userManager;
        private readonly SignInManager<FreakyFashionUser> _signInManager;

        public AccountIconsViewComponent(UserManager<FreakyFashionUser> userManager, 
            SignInManager<FreakyFashionUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (_signInManager.IsSignedIn(HttpContext.User))
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                return View("SignedIn", user.UserName);
            }

            return View();
        }
    }
}
