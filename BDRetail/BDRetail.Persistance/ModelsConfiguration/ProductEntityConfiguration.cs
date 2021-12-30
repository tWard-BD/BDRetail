using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BDRetail.Persistance.Models;

namespace BDRetail.Persistance.ModelsConfiguration
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.Id);

            builder.Property(product => product.Name)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);

            builder.Property(product => product.ProductCode)
                   .IsRequired(true)
                   .HasMaxLength(50)
                   .IsUnicode();

            builder.Property(product => product.Brand)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);

            builder.Property(product => product.State)
                   .IsRequired(true)
                   .HasMaxLength(20)
                   .IsUnicode(true);

            builder.Property(product => product.Price)
                   .IsRequired(true)
                   .HasPrecision(19, 4);

            builder.HasOne(category => category.Category)
                   .WithMany(product => product.Products)
                   .HasForeignKey(prod => prod.CategoryId);
        }
    }
}
