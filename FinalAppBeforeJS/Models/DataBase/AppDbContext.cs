using Microsoft.EntityFrameworkCore;

namespace FinalAppBeforeJS.Models.DataBase
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) => Database.EnsureCreated();
    }
}
