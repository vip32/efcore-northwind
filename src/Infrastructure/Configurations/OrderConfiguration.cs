using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Infrastructure
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(e => e.Id).HasValueGenerator<GuidValueGenerator>().ValueGeneratedOnAdd();
            builder.Property(e => e.FreightCost)
                .HasColumnType("money")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.OrderedDate).HasColumnType("datetime");
            builder.Property(e => e.RequiredDate).HasColumnType("datetime");
            builder.Property(e => e.ShippedDate).HasColumnType("datetime");

            builder.OwnsMany(e => e.OrderDetails, o =>
            {
                //o.HasKey(nameof(OrderDetail..Id), nameof(Product.Id));

                o.Property(e => e.Quantity).IsRequired().HasDefaultValueSql("((1))");
                o.Property(e => e.UnitPrice).IsRequired().HasColumnType("money");

                //o.HasOne(d => d.Product)
                //    .WithMany(p => p.OrderDetails)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Order_Details_Products");
            });

            builder.HasOne(d => d.Shipper)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.ShipVia)
                .HasConstraintName("FK_Orders_Shippers");
        }
    }
}
