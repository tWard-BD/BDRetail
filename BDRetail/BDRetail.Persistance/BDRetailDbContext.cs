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

            new ProductEntityConfiguration().Configure(modelBuilder.Entity<Product>());
        }

        public DbSet<Product> Products { get; set; }
    }
}