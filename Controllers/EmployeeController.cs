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
        var compaines = context.Companies;
        ViewBag.compaines=compaines;
        return View();
       }

       public IActionResult Edit()
       {
        return View();
       }

       public IActionResult Delete(){
        return RedirectToAction(nameof(Index));
       }
    }
}