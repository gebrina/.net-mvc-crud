using Microsoft.AspNetCore.Mvc;

namespace EmployeeMgmt.Controllers
{
    public class EmployeeController:Controller{
       
       public IActionResult Index()
       {
        return View();
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