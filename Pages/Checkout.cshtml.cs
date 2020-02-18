using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FreakyFashion
{
    public class CheckoutModel : PageModel
    {
        private readonly UserManager<FreakyFashionUser> _userManager;

        public Cart Cart { get; private set; }

        [BindProperty]
        public FormModel UserData { get; set; }

        [BindProperty]
        [Display(Name = "Register me as member!")]
        public bool IsNewAccount { get; set; }

        public CheckoutModel(UserManager<FreakyFashionUser> userManager)
        {
            _userManager = userManager;
        }

        public void OnGet()
        {
            Cart = JsonConvert.DeserializeObject<Cart>(HttpContext.Session.GetString("Cart"));

            if(Cart == null)
            {
                Cart = new Cart(null);
            }

            var getUser = _userManager.GetUserAsync(HttpContext.User);

            var getUserData = getUser.ContinueWith(task =>
            {
                var user = task.Result;

                if (user != null)
                {
                    UserData = new FormModel();

                    UserData.FirstName = user.FirstName;
                    UserData.LastName = user.LastName;
                    UserData.SocialSecurityNumber = user.SocialSecurityNumber;
                    UserData.Street = user.Street;
                    UserData.Zip = user.Zip;
                    UserData.City = user.City;
                }
            });

            getUserData.Wait();
        }

        public class FormModel
        {
            [Required]
            [Display(Name="First Name")]
            public string FirstName { get; set; } = "";

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; } = "";

            [Required]
            [Display(Name = "Social security number")]
            public string SocialSecurityNumber { get; set; } = "";

            [Required]
            [Display(Name = "Street address")]
            public string Street { get; set; } = "";

            [Required]
            [Display(Name = "Zip code")]
            public string Zip { get; set; } = "";

            [Required]
            public string City { get; set; } = "";
        }
    }
}