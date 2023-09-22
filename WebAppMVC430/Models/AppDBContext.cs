using Microsoft.EntityFrameworkCore;

namespace WebAppMVC430.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options) 
        {
                
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
