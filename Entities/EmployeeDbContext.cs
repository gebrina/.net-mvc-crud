using Microsoft.EntityFrameworkCore;
using EmployeeMgmt.Models;
using EmployeeMgmt.Configuration;

namespace EmployeeMgmt.Entities
{
    public class EmployeeDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
          var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
          builder.UseNpgsql(configuration.GetConnectionString("EmpDbCon"));
        } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
              modelBuilder.Entity<Employee>().HasIndex(e=>e.PhoneNumber).IsUnique(true);
              modelBuilder.Entity<Company>().HasIndex(c=>c.Name).IsUnique(true);
              modelBuilder.ApplyConfiguration(new CompanyConfiguration());
              modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }

        public DbSet<Employee> Employees {get;set;}
        public DbSet<Company> Companies {get;set;}
    }

}