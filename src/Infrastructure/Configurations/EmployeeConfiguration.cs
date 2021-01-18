using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Infrastructure
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Id).HasValueGenerator<GuidValueGenerator>().ValueGeneratedOnAdd();

            builder.Property(e => e.BirthDate).HasColumnType("datetime");

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.HireDate).HasColumnType("datetime");

            builder.Property(e => e.HomePhone).HasMaxLength(24);

            builder.Property(e => e.Notes).HasColumnType("ntext");

            builder.Property(e => e.Photo).HasColumnType("image");

            builder.Property(e => e.PhotoPath).HasMaxLength(255);

            builder.Property(e => e.Title).HasMaxLength(32);

            builder.HasOne(d => d.Manager)
                .WithMany(p => p.DirectReports)
                .HasForeignKey(d => d.ReportsTo)
                .HasConstraintName("FK_Employees_Employees");
        }
    }
}
