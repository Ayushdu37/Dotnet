using Microsoft.EntityFrameworkCore;
using OneToManyEF.Models;

namespace OneToManyEF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API configuration for One-to-Many

            modelBuilder.Entity<Customers>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
