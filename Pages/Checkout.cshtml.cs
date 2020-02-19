using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion.Data;
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
        private readonly SignInManager<FreakyFashionUser> _signInManager;
        private readonly FreakyFashionContext _context;

        public Cart Cart { get; private set; }

        [BindProperty]
        public FormModel UserData { get; set; }

        [BindProperty]
        [Display(Name = "Register me as member!")]
        public bool IsNewAccount { get; set; }

        public CheckoutModel(FreakyFashionContext context, 
            SignInManager<FreakyFashionUser> signInManager,
            UserManager<FreakyFashionUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
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
                    UserData.Email = user.Email;
                    UserData.Phone = user.PhoneNumber;
                    UserData.SocialSecurityNumber = user.SocialSecurityNumber;
                    UserData.Street = user.Street;
                    UserData.Zip = user.Zip;
                    UserData.City = user.City;
                }
            });

            getUserData.Wait();
        }

        public async Task<IActionResult> OnPostAsync()
        {            
            FreakyFashionUser user = await GetUser();
            Customer customer = _context.Customers.FirstOrDefault(c => c.SocialSecurityNumber.Equals(UserData.SocialSecurityNumber));

            if(customer == null)
            {
                customer = CreateNewCustomer(user != null);
            }
            else
            {
                UpdateCustomerData(customer);
            }
            
            Cart = JsonConvert.DeserializeObject<Cart>(HttpContext.Session.GetString("Cart"));

            foreach(var orderItem in Cart.CartContent) {
                orderItem.Product = _context.Products.Find(orderItem.Product.Id);
            }
            
            var order = new Order(Cart.CartContent, customer);

            _context.Orders.Add(order);
            _context.SaveChanges();

            return RedirectToPage("/OrderConfirmation", new { orderGuid = order.OrderGuid.ToString() });
        }

        private void UpdateCustomerData(Customer customer)
        {
            customer.City = UserData.City;
            customer.LastName = UserData.LastName;
            customer.Zip = UserData.Zip;
            customer.Street = UserData.Street;
            customer.PhoneNumber = UserData.Phone;
            customer.Email = UserData.Email;

            _context.SaveChanges();
        }

        private Customer CreateNewCustomer(bool isMember)
        {
            var customer = new Customer(UserData.FirstName,
                UserData.LastName,
                UserData.SocialSecurityNumber,
                UserData.Phone,
                UserData.Email,
                UserData.Street,
                UserData.Zip,
                UserData.City,
                isMember);
            
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return _context.Customers.First(c => c.Email.Equals(customer.Email));
        }

        private async Task<FreakyFashionUser> GetUser()
        {
            FreakyFashionUser user = null;

            if (_signInManager.IsSignedIn(HttpContext.User))
            {
               user = await _userManager.GetUserAsync(HttpContext.User);
            }
            else if (IsNewAccount)
            {

                user = CreateUser();
                await _userManager.CreateAsync(user, "Secret!123");
            }

            return user;
        }

        private FreakyFashionUser CreateUser()
        {
            return new FreakyFashionUser
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = UserData.FirstName,
                LastName = UserData.LastName,
                SocialSecurityNumber = UserData.SocialSecurityNumber,
                Email = UserData.Email,
                NormalizedEmail = UserData.Email.ToUpper(),
                EmailConfirmed = true,
                Street = UserData.Street,
                Zip = UserData.Zip,
                City = UserData.City,
                UserName = UserData.Email,
                NormalizedUserName = UserData.Email.ToUpper(),
                PhoneNumber = UserData.Phone,
            };
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

            [Required]
            [Display(Name = "E-mail")]
            public string Email { get; set; } = "";

            [Display(Name = "Phone number")]
            public string Phone { get; set; } = "";
        }
    }
}