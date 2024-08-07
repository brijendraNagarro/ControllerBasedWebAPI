using Microsoft.EntityFrameworkCore;

namespace WebAPIProject.Model
{
    public class EmplyeeContext:DbContext
    {
        public EmplyeeContext(DbContextOptions<EmplyeeContext> options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set;}
    }
}
