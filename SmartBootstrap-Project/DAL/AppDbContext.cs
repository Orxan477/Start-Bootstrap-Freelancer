using Microsoft.EntityFrameworkCore;
using SmartBootstrap_Project.Models;

namespace SmartBootstrap_Project.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
        }

        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Setting> Settings { get; set; }
    }
}
