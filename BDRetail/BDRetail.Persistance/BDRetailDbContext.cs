using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BDRetail.Persistance.Models;
using BDRetail.Persistance.ModelsConfiguration;

namespace BDRetail.Persistance
{
    public class BDRetailDbContext : IdentityDbContext
    {
        public BDRetailDbContext(DbContextOptions<BDRetailDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new UserProfileEntityConfiguration().Configure(modelBuilder.Entity<UserProfile>());

            new ProductEntityConfiguration().Configure(modelBuilder.Entity<Product>());

            new ProductCategoryEntityConfiguration().Configure(modelBuilder.Entity<ProductCategory>());

            new ProductImageEntityConfiguration().Configure(modelBuilder.Entity<ProductImage>());

            new ProductRelationEntityConfiguration().Configure(modelBuilder.Entity<ProductRelation>());

            new OrderEntityConfiguration().Configure(modelBuilder.Entity<Order>());

            new OrderHistoryEntityConfiguration().Configure(modelBuilder.Entity<OrderHistory>());

            new OrderBillingDetailsEntityConfiguration().Configure(modelBuilder.Entity<OrderBillingDetails>());

            new OrderDeliveryDetailsEntityConfiguration().Configure(modelBuilder.Entity<OrderDeliveryDetails>());

            new OrderLineEntityConfiguration().Configure(modelBuilder.Entity<OrderLine>());

            new OrderFailureEntityConfiguration().Configure(modelBuilder.Entity<OrderFailure>());

            new DiscountEntityConfiguration().Configure(modelBuilder.Entity<Discount>());
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<ProductRelation> ProductRelations { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderHistory> OrderHistories { get; set; }

        public DbSet<OrderBillingDetails> OrderBillingDetails { get; set; }

        public DbSet<OrderDeliveryDetails> OrderDeliveryDetails { get; set; }

        public DbSet<OrderLine> OrderLines { get; set; }

        public DbSet<OrderFailure> OrderFailures { get; set; }

        public DbSet<Discount> Discounts { get; set; }
    }
}