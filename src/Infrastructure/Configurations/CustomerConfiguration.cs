using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Infrastructure
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(e => e.Id)
                .HasValueGenerator<GuidValueGenerator>().ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(128);
            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(128);
            builder.Property(e => e.Title)
                .HasMaxLength(32);
            builder.Property(e => e.Phone)
                .HasMaxLength(32);

            //builder.HasOne(d => d.Address)
            //    .WithOne()
            //    .IsRequired(false)
            //    .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
