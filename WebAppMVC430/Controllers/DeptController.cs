using Microsoft.AspNetCore.Mvc;
using WebAppMVC430.Models;

namespace WebAppMVC430.Controllers
{
    public class DeptController : Controller
    {
        private readonly IDepartmentRepository repository;

        public DeptController(IDepartmentRepository repository) 
        {
            this.repository = repository; // DI
        }
        public IActionResult Index()
        {
            List<Department> list = repository.GetDepartments();
            return View(list);
        }
    }
}
