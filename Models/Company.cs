using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeMgmt.Models
{
[Table("companies")]
public class Company
{
    [Column(name:"company_id")]
    public Guid CompanyId {get;set;}

    [Column(name:"company_name")]
    [Required(ErrorMessage ="Company name is required.")]
    public string Name {get;set;} = string.Empty;
 
    [Column(name:"address",TypeName ="varchar(255)")]
    public string Address {get;set;} = string.Empty;

    public ICollection<Employee>? Employees {get;set;}
}
}