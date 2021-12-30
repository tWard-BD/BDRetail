using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BDRetail.Persistance.Models;

namespace BDRetail.Persistance.ModelsConfiguration
{
    public class OrderDeliveryDetailsEntityConfiguration : IEntityTypeConfiguration<OrderDeliveryDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDeliveryDetails> builder)
        {
            builder.HasKey(orderDeliveryDetails => orderDeliveryDetails.Id);

            builder.Property(orderDeliveryDetails => orderDeliveryDetails.FirstName)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);
            
            builder.Property(orderDeliveryDetails => orderDeliveryDetails.LastName)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);
            
            builder.Property(orderDeliveryDetails => orderDeliveryDetails.City)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);
            
            builder.Property(orderDeliveryDetails => orderDeliveryDetails.Address)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);
            
            builder.Property(odd => odd.PostCode)
                   .IsRequired(false)
                   .HasMaxLength(50)
                   .IsUnicode(true);

            builder.Property(orderDeliveryDetails => orderDeliveryDetails.DeliveryDate)
                   .IsRequired(true);
        }
    }
}
