using Microsoft.AspNetCore.Mvc;

namespace EmployeeMgmt.Controllers
{
    public class CompanyController:Controller{
       
       public IActionResult Index()
       {
        return View();
       }

       public IActionResult Create()
       {
        return View();
       }

       public IActionResult Edit()
       {
        return View();
       }
    }
}