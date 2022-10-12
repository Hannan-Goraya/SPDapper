using Microsoft.EntityFrameworkCore;
using SPDapper.Models;

namespace SPDapper.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Employee> employees { get; set; }

        public DbSet<Department> departments { get; set; }

    }
}
