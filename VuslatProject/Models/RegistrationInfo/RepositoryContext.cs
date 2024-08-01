using Microsoft.EntityFrameworkCore;


namespace VuslatProject.Models.RegistrationInfo
{
    public class RepositoryContext : DbContext
    {

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Visitor> Visitors { get; set; }


        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }
    }
}
