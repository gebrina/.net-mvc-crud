using Microsoft.AspNetCore.Mvc;
using EmployeeMgmt.Entities;

namespace EmployeeMgmt.Controllers
{
    public class EmployeeController:Controller{
      private EmployeeDbContext context  = new();
      
       public IActionResult Index()
       {
        var employees = context.Employees;
        Console.WriteLine(employees.Count());
        return View(employees);
       }

       public IActionResult Add()
       {
        return View();
       }

       public IActionResult Edit()
       {
        return View();
       }
    }
}