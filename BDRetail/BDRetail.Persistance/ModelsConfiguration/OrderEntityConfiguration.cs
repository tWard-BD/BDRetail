using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BDRetail.Persistance.Models;

namespace BDRetail.Persistance.ModelsConfiguration
{
    public class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(order => order.Id);

            builder.Property(order => order.CreatedOn)
                   .IsRequired(true);

            builder.Property(order => order.State)
                   .IsRequired(true)
                   .HasMaxLength(50)
                   .IsUnicode(true);

            builder.HasOne(order => order.OrderBillingDetails)
                   .WithOne()
                   .HasForeignKey<Order>(order => order.OrderBillingDetailsId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(order => order.OrderDeliveryDetails)
                   .WithOne()
                   .HasForeignKey<Order>(order => order.OrderDeliveryDetailsId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
