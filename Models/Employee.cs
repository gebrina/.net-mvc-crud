using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMgmt.Models
{
     [Table("employees")]
    public class Employee{
        [Column(name:"employee_id")]
        public Guid Id {get;set;}
        
        [Column(name:"first_name",TypeName ="varchar(25)")]
        public string FristName {get;set;} = string.Empty;

        [Column(name:"last_name",TypeName ="varchar(25)")]
        public string LastName {get;set;} = string.Empty;

        [Column(name:"position",TypeName ="varchar(25)")]
        public string Position {get;set;} = string.Empty;

        [Column(name:"phone_number",TypeName ="varchar(25)")]
        public string PhoneNumber {get;set;} = string.Empty;
        public Guid CompanyId {get;set;}
        public Company Company {get;set;}
    }
}