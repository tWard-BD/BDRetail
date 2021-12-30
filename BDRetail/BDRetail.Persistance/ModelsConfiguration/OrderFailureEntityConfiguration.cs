using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BDRetail.Persistance.Models;

namespace BDRetail.Persistance.ModelsConfiguration
{
    public class OrderFailureEntityConfiguration : IEntityTypeConfiguration<OrderFailure>
    {
        public void Configure(EntityTypeBuilder<OrderFailure> builder)
        {
            builder.HasKey(orderFail => orderFail.Id);

            builder.Property(orderFail => orderFail.CreatedOn)
                   .IsRequired(true);

            builder.Property(orderFail => orderFail.Reason)
                   .IsRequired(true)
                   .IsUnicode(true);
        }
    }
}
