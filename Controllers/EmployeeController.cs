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
        var employee = context.Employees.Include(e=>e.Company).FirstOrDefault(employee=>employee.Id==new Guid(emp_id));
        ViewBag.compaines = context.Companies;

        return View(employee);
       }

       [HttpPost]
       public IActionResult Edit(Employee employee){
         if(ModelState.IsValid)
         {
          context.Employees.Update(employee);
          context.SaveChanges();
          return RedirectToAction(nameof(Index));
         }
         
        var employeeTobeUpdated = context.Employees.FirstOrDefault(emp=>emp.Id==employee.Id);
        ViewBag.compaines = context.Companies;
        
         return View(employeeTobeUpdated);
       }
       
       public IActionResult Delete(string emp_id){
        Employee employee = context.Employees.FirstOrDefault(e=>e.Id==new Guid(emp_id));
        if(employee==null) return RedirectToAction(nameof(Index));
        context.Employees.Remove(employee);
        context.SaveChanges();
        return RedirectToAction(nameof(Index));
       }
    }
}