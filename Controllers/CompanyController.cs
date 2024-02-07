using Microsoft.AspNetCore.Mvc;
using EmployeeMgmt.Entities;
using EmployeeMgmt.Models;

namespace EmployeeMgmt.Controllers
{
    public class CompanyController:Controller{
       private EmployeeDbContext context = new();

       public IActionResult Index()
       {
        var companies = context.Companies;
        return View(companies);
       }

       public IActionResult Add()
       {
        var employees = context.Employees.Where(e=>e.Company==null).ToArray();
        ViewBag.employees = employees;
        return View();
       }
 
       [HttpPost]
       public IActionResult Add(Company company)
       {
        if(ModelState.IsValid){
          context.Companies.Add(company);
          context.SaveChanges();
          return RedirectToAction(nameof(Index));
        };

        var employees = context.Employees.Where(e=>e.Company==null).ToArray();
        ViewBag.employees = employees;
        return View();
       }

       public IActionResult Edit()
       {
        return View();
       }

       public IActionResult Delete()
       {
        return RedirectToAction(nameof(Index));
       }
    }
}