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
        [Route("/departments")]
        [Route("/mohit")]

        public IActionResult Index()
        {
            List<Department> list = repository.GetDepartments();
            ViewData["Title"] = "Department List";
            ViewData["desc"] = "Department List of SIRCL TECH";
            return View("depts",list);
        }
        public IActionResult Detail(int? id) {

            Department department = repository.GetDepartmentById(id??10);
            ViewData["Title"] = "Department Detail";

            return View(department);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Title"] = "Create New Department";
            return View();  
        }

        [HttpPost]
        public IActionResult Create(Department model)
        {
            ViewData["Title"] = "Create New Department";
            return View();
        }
    }
}
