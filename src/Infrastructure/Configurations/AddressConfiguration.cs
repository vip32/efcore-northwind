using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Infrastructure
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(e => e.Id).HasValueGenerator<GuidValueGenerator>().ValueGeneratedOnAdd();

            builder.Property(e => e.Line1).HasMaxLength(100);
            builder.Property(e => e.Line2).HasMaxLength(100);
            builder.Property(e => e.City).HasMaxLength(50);
            builder.Property(e => e.Country).HasMaxLength(50);
            builder.Property(e => e.PostalCode).HasMaxLength(50);
        }
    }
}
