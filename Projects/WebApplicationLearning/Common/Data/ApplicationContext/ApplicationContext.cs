using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.ApplicationContext
{
    public class DbApplicationContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }

        public DbApplicationContext(DbContextOptions<DbApplicationContext> options)
            : base(options)
        {
        }
    }
}
