using CURDOprationsDimo.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDOperationsDemo
{
    public class CRUDDbContext : DbContext
    {
        public CRUDDbContext(DbContextOptions<CRUDDbContext> options) : base(options)   
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Employee>().ToTable("Employees", "HR");
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
