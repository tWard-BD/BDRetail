using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BDRetail.Persistance.Models;

namespace BDRetail.Persistance.ModelsConfiguration
{
    public class PaymentTransactionEntityConfiguration : IEntityTypeConfiguration<PaymentTransaction>
    {
        public void Configure(EntityTypeBuilder<PaymentTransaction> builder)
        {
            builder.HasKey(paymentTransaction => paymentTransaction.Id);

            builder.Property(paymentTransaction => paymentTransaction.State)
                   .IsRequired(true)
                   .HasMaxLength(50)
                   .IsUnicode(true);

            builder.Property(paymentTransaction => paymentTransaction.Description)
                   .IsRequired(false)
                   .HasMaxLength(255)
                   .IsUnicode(true);

            builder.Property(paymentTransaction => paymentTransaction.CreatedOn)
                   .IsRequired(true);
        }
    }
}
