using Microsoft.EntityFrameworkCore;
using EmployeeMgmt.Models;

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
      
        }

        public DbSet<Employee> Employees {get;set;}
        public DbSet<Company> Companies {get;set;}
    }

}