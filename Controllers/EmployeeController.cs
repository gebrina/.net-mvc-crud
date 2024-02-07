using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeMgmt.Entities;
using EmployeeMgmt.Models;

namespace EmployeeMgmt.Controllers
{
    public class EmployeeController:Controller{
      private EmployeeDbContext context  = new();
      
       public IActionResult Index()
       {
        var employees = context.Employees.Include(e=>e.Company);
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
        if(ModelState.IsValid){  
          context.Employees.Add(employee);
          context.SaveChanges();
          return RedirectToAction(nameof(Index));
        }
        
        var compaines = context.Companies;
        ViewBag.compaines = compaines;
        return View();
      }
     
      [HttpGet]
      public IActionResult Edit(string emp_id)
       { 
        Console.WriteLine(emp_id);
        return View();
       }

       [HttpPost]
       public IActionResult Edit(Employee employee)
       {
        if(ModelState.IsValid){
          var savedEmployee = context.Employees.FirstOrDefault(e=>e.Id.Equals(employee.Id));
          if(savedEmployee==null) return View();
          context.Employees.Update(employee);
          context.SaveChanges();

          return RedirectToAction(nameof(Index));
        }

        return View();
       }

       public IActionResult Delete(){
        return RedirectToAction(nameof(Index));
       }
    }
}