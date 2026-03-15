using LazyLoadingThroughPagination.Models;
using Microsoft.EntityFrameworkCore;

namespace LazyLoadingThroughPagination.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
