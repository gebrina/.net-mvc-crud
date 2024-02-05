using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EmployeeMgmt.Models;

namespace EmployeeMgmt.Configuration
{
    public class EmployeeConfiguration:IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
             List<Employee> employees= new List<Employee>{
              new Employee{Id=Guid.NewGuid(),FristName="Doe", LastName="John"},
              new Employee {Id=Guid.NewGuid(),FristName="Smith", LastName="Kyle"},
              new Employee {Id = Guid.NewGuid(), FristName="Helen", LastName="Million"}
             }; 
          
            builder.HasData(employees);
        }
    }
}