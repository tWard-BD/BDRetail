using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BDRetail.Persistance.Models;

namespace BDRetail.Persistance.ModelsConfiguration
{
    public class ProductImageEntityConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasKey(productImage => productImage.Id);

            builder.Property(productImage => productImage.ImageUrl)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);

            builder.HasOne(product => product.Product)
                   .WithMany(productImages => productImages.Images)
                   .HasForeignKey(product => product.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
