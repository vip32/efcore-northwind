using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Infrastructure
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Id).HasValueGenerator<GuidValueGenerator>().ValueGeneratedOnAdd();
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.QuantityPerUnit).HasMaxLength(32);

            builder.Property(e => e.ReorderLevel).HasDefaultValueSql("((0))");

            builder.Property(e => e.UnitPrice)
                .HasColumnType("money")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.UnitsInStock).HasDefaultValueSql("((0))");

            builder.Property(e => e.UnitsOnOrder).HasDefaultValueSql("((0))");
        }
    }
}
