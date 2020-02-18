using FreakyFashion.Data.Entities;
using FreakyFashion.Data.EntityConfigurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FreakyFashion.Data
{
    public class FreakyFashionContext : IdentityDbContext<FreakyFashionUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public FreakyFashionContext(DbContextOptions<FreakyFashionContext> options)
            :base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());

            var roles = SeedRoles(modelBuilder);
            SeedUsers(modelBuilder, roles);
        }

        private static List<IdentityRole> SeedRoles(ModelBuilder modelBuilder)
        {
            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
            };

            roles.ForEach(role =>
                modelBuilder.Entity<IdentityRole>().HasData(role));

            return roles;
        }

        private static void SeedUsers(ModelBuilder modelBuilder, List<IdentityRole> roles)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var admin = new IdentityUser()
            {
                Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                UserName = "admin@nomail.com",
                NormalizedUserName = "ADMIN@NOMAIL.COM",
                Email = "admin@nomail.com",
                NormalizedEmail = "ADMIN@NOMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "0707-12345",
                PasswordHash = hasher.HashPassword(null, "Admin123!")
            };

            modelBuilder.Entity<IdentityUser>().HasData(admin);

            var administrator = roles.FirstOrDefault(x => x.Name == "Administrator");

            if (administrator != null)
            {
                modelBuilder.Entity<IdentityUserRole<string>>()
                    .HasData(new IdentityUserRole<string>
                    {
                        UserId = admin.Id,
                        RoleId = administrator.Id
                    });
            }
        }
    }
}
