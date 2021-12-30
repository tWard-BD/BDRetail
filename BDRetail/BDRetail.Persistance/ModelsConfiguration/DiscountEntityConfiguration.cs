using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BDRetail.Persistance.Models;

namespace BDRetail.Persistance.ModelsConfiguration
{
    public class DiscountEntityConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasKey(discount => discount.Id);

            builder.Property(discount => discount.Code)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);

            builder.Property(discount => discount.Price)
                   .IsRequired(true)
                   .HasPrecision(19, 4);
        }
    }
}
