using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BDRetail.Persistance.Models;

namespace BDRetail.Persistance.ModelsConfiguration
{
    public class ProductCategoryEntityConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(productCategory => productCategory.Id);

            builder.Property(productCategory => productCategory.Name)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);

            builder.Property(productCategory => productCategory.ImageUrl)
                   .IsRequired(false)
                   .HasMaxLength(255)
                   .IsUnicode(true);

            builder.HasOne(productCategory => productCategory.SubCategory)
                   .WithOne()
                   .HasForeignKey<ProductCategory>(prodCategory => prodCategory.SubCategoryId);
        }
    }
}
