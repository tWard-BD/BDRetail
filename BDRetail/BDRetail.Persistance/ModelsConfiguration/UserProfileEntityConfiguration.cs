using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BDRetail.Persistance.Models;

namespace BDRetail.Persistance.ModelsConfiguration
{
    public class UserProfileEntityConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasKey(user => user.Id);

            builder.Property(user => user.UserId)
                   .IsRequired(true);

            builder.Property(user => user.FirstName)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);

            builder.Property(user => user.LastName)
                   .IsRequired(true)
                   .HasMaxLength(255)
                   .IsUnicode(true);
            
            builder.Property(user => user.ImageUrl)
                   .IsRequired(false)
                   .HasMaxLength(255)
                   .IsUnicode(true);

            builder.HasOne(user => user.User)
                   .WithOne(appUser => appUser.UserProfile)
                   .HasForeignKey<UserProfile>(user => user.UserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
