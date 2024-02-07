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

       public IActionResult Edit(string comp_id)
       {
        var company = context.Companies.FirstOrDefault(
          company=>company.CompanyId.Equals(new Guid(comp_id))
          );
        return View(company);
       }

       [HttpPost]
       public IActionResult Edit(Company company)
        {
          if(ModelState.IsValid){
            context.Companies.Update(company);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
          }
         var companyTobeUpdated = context.Companies.
         FirstOrDefault(comp=>comp.CompanyId==company.CompanyId);
          
         return View(company);
       }

       public IActionResult Delete()
       {
        return RedirectToAction(nameof(Index));
       }
    }
}