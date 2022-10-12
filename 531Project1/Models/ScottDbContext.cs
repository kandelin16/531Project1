using Microsoft.EntityFrameworkCore;

namespace _531Project1.Models
{
    public class ScottDbContext : DbContext
    {
        public ScottDbContext(DbContextOptions<ScottDbContext> options) : base(options)
        {

        }

        public DbSet<Scott> Scott { get; set; }

    }
}
