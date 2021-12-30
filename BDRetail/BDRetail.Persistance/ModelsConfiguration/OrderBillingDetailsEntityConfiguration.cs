using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BDRetail.Persistance.Models;

namespace BDRetail.Persistance.ModelsConfiguration
{
    public class OrderBillingDetailsEntityConfiguration : IEntityTypeConfiguration<OrderBillingDetails>
    {
        public void Configure(EntityTypeBuilder<OrderBillingDetails> builder)
        {
            builder.HasKey(orderBillDetails => orderBillDetails.Id);

            builder.Property(orderBillDetails => orderBillDetails.FirstName)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);

            builder.Property(orderBillDetails => orderBillDetails.LastName)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);

            builder.Property(orderBillDetails => orderBillDetails.City)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);

            builder.Property(orderBillDetails => orderBillDetails.Address)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);

            builder.Property(orderBillDetails => orderBillDetails.PostCode)
                   .IsRequired(false)
                   .HasMaxLength(50)
                   .IsUnicode(true);
        }
    }
}
