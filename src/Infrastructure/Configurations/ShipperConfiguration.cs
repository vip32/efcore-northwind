using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Infrastructure
{
    public class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.Property(e => e.Id).HasValueGenerator<GuidValueGenerator>().ValueGeneratedOnAdd();
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.Fax).HasMaxLength(32);

            builder.Property(e => e.HomePage).HasColumnType("ntext");

            builder.Property(e => e.Phone).HasMaxLength(32);
        }
    }
}
