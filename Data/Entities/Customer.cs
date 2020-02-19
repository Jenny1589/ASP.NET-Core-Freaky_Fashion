using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace FreakyFashion.Data.Entities
{
    public class Customer
    {
        public int Id { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; protected set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public bool IsMember { get; protected set; }

        public IEnumerable<Order> Orders { get; protected set; }

        public Customer(string firstName, 
            string lastName, 
            string socialSecurityNumber, 
            string phoneNumber, 
            string email, 
            string street, 
            string zip, 
            string city,
            bool isMember)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            PhoneNumber = phoneNumber;
            Email = email;
            Street = street;
            Zip = zip;
            City = city;
            IsMember = isMember;
        }


    }
}
