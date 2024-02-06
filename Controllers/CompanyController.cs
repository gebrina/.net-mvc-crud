using Microsoft.AspNetCore.Mvc;
using EmployeeMgmt.Entities;

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