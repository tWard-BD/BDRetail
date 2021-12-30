using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BDRetail.Persistance.Models;

namespace BDRetail.Persistance.ModelsConfiguration
{
    public class ProductRelationEntityConfiguration : IEntityTypeConfiguration<ProductRelation>
    {
        public void Configure(EntityTypeBuilder<ProductRelation> builder)
        {
            builder.HasKey(prodRelation => new { prodRelation.ProductId, prodRelation.RelatedId });

            builder.HasOne(product => product.Product)
                   .WithMany(related => related.RealtedProducts)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(related => related.Related)
                   .WithMany(relatedTo => relatedTo.RelatedToProducts)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
