using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BDRetail.Persistance.Models;

namespace BDRetail.Persistance.ModelsConfiguration
{
    public class OrderHistoryEntityConfiguration : IEntityTypeConfiguration<OrderHistory>
    {
        public void Configure(EntityTypeBuilder<OrderHistory> builder)
        {
            builder.HasKey(orderHistory => orderHistory.Id);

            builder.Property(orderHistory => orderHistory.CreatedOn)
                   .IsRequired(true);
            
            builder.Property(orderHistory => orderHistory.State)
                   .IsRequired(true)
                   .HasMaxLength(50)
                   .IsUnicode(true);

            builder.HasOne(orderHistory => orderHistory.Order)
                   .WithOne()
                   .HasForeignKey<OrderHistory>(orderHistory => orderHistory.OrderId)
                   .IsRequired(true);
        }
    }
}
