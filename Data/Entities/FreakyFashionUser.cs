using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace FreakyFashion.Data.Entities
{
    public class FreakyFashionUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        public IEnumerable<Order> Orders { get; protected set; } 
    }
}
