using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BDRetail.Persistance.Models;

namespace BDRetail.Persistance.ModelsConfiguration
{
    public class OrderLineEntityConfiguration : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder.HasKey(orderLine => orderLine.Id);

            builder.HasOne(orderLine => orderLine.Order)
                   .WithMany(order => order.OrderLines)
                   .HasForeignKey(orderLine => orderLine.OrderId)
                   .OnDelete(DeleteBehavior.Cascade)
                   .IsRequired(true);

            builder.HasOne(orderLine => orderLine.Product)
                   .WithMany()
                   .HasForeignKey(orderLine => orderLine.ProductId)
                   .OnDelete(DeleteBehavior.Cascade)
                   .IsRequired(true);
        }
    }
}
