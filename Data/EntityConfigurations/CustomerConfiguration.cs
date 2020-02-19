using FreakyFashion.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FreakyFashion.Data.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.Property(c => c.FirstName)
                .IsRequired();

            builder.Property(c => c.LastName)
                .IsRequired();

            builder.Property(c => c.Email)
                .IsRequired();

            builder.Property(c => c.SocialSecurityNumber)
                .IsRequired();

            builder.Property(c => c.Street)
                .IsRequired();

            builder.Property(c => c.City)
                .IsRequired();

            builder.Property(c => c.Zip)
                .IsRequired();
        }
    }
}
