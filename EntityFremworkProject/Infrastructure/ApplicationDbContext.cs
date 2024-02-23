using EntityFremworkProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFremworkProject.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
            
        }

        public DbSet<Shop> shops { get; set; }
    }
}
