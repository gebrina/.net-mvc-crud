using Microsoft.AspNetCore.Mvc;
using EmployeeMgmt.Entities;
using EmployeeMgmt.Models;

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
      
      [HttpPost]
      public IActionResult Add(Employee employee)
      {
        if(ModelState.IsValid) return RedirectToAction(nameof(Index));
        
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