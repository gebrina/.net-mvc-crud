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
                new Employee {
                            Id=new Guid("7d40cfc8-f801-4f84-80e1-a8605cbda9f5"),
                            FristName="Doe",
                            LastName="John",
                            PhoneNumber="2519-2334-23-34",
                            Position="Software Enginner I",
                            CompanyId = new Guid("f1bd225f-a114-473b-b9ae-13de83feac57")
                           },
              new Employee {
                             Id=new Guid("bfa08ba6-58ae-4ebc-b739-c61c585dd2ec"),
                             FristName="Smith",
                             LastName="Kyle",
                             PhoneNumber="2519-4334-23-44",
                             Position="Software Enginner II",
                             CompanyId = new Guid("c56d2e35-cbbc-4c11-9382-c19a77d0f025")
                            },
              new Employee {
                             Id=new Guid("d8aa10d8-32b1-46eb-8446-0caa6634c6fa"), 
                             FristName="Helen", 
                             LastName="Million",
                             PhoneNumber="+1029-2334-23-34",
                             Position="Software Enginner III",
                             CompanyId=new Guid("67e91a90-56e4-4339-9fbe-c370d16db1d5")
                            }
             }; 
             
            builder.HasData(employees);
        }
    }
}