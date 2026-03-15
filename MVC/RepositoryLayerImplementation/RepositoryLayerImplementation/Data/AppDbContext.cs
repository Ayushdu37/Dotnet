using Microsoft.EntityFrameworkCore;
using RepositoryLayerImplementation.Models;

namespace RepositoryLayerImplementation.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Books");

                entity.HasKey(b => b.Id);

                entity.Property(b => b.FullName)
                      .HasMaxLength(25)
                      .IsRequired();

                entity.Property(b => b.Author)
                      .HasMaxLength(50);

                entity.Property(b => b.Genre)
                      .HasMaxLength(50);

                entity.Property(b => b.Price)
                      .HasColumnType("real");
                entity.HasData(
                    new Book { Id = 101, FullName = "Harry Potter", Author = "J.K Rowling", Genre = "Fantasy", Price = 500 },
                    new Book { Id = 102, FullName = "Atomic Habits", Author = "James Clear", Genre = "Self Help", Price = 450 },
                    new Book { Id = 103, FullName = "Rich Dad Poor Dad", Author = "Robert Kiyosaki", Genre = "Finance", Price = 350 },
                    new Book { Id = 104, FullName = "The Alchemist", Author = "Paulo Coelho", Genre = "Fiction", Price = 300 },
                    new Book { Id = 105, FullName = "Harry Potter", Author = "J.K Rowling", Genre = "Fantasy", Price = 600 }
                );
            });
        }
    }
}
