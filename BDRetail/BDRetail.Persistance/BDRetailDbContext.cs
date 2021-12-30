using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
        }
    }
}