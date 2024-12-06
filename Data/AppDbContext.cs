using Microsoft.EntityFrameworkCore;
using HAF_Project.Models;

namespace HAF_Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //Insert models to create Tables
        //Example:
        //public DbSet<Languages> Languages { get; set; }
    }
}
