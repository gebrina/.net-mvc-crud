using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EmployeeMgmt.Models;

namespace EmployeeMgmt.Configuration
{
    public class CompanyConfiguration:IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            List<Company> companies = new List<Company>{
                new Company{CompanyId=new Guid("f1bd225f-a114-473b-b9ae-13de83feac57"), Name="Hi Tech", Address="Addis Ababa, Ethiopia"},
                new Company{CompanyId=new Guid("c56d2e35-cbbc-4c11-9382-c19a77d0f025"), Name="Lead Tech",Address="Nairobi, Kenya"},
                new Company{CompanyId=new Guid("67e91a90-56e4-4339-9fbe-c370d16db1d5"),Name="Info Model", Address="Legos, Naigeria"}
            };

            builder.HasData(companies);
        }
    }
}