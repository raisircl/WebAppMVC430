using Microsoft.AspNetCore.Mvc;
using WebAppMVC430.Models;

namespace WebAppMVC430.Controllers
{
    public class EmployeeController : Controller
    {
        
       

       
        public IActionResult Index()
        {
            EmployeeRepository repository = new EmployeeRepository();   
            List<Employee> employees=repository.GetEmployees();
            //return Json(employees);
            return View(employees);
        }
    }
}
