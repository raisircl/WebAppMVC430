using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebAppMVC430.Models;

namespace WebAppMVC430.Controllers
{
    public class DeptController : Controller
    {
        private readonly IDepartmentRepository repository;
        private readonly ICountryRepository countryRepository;

        public DeptController(IDepartmentRepository repository, ICountryRepository countryRepository)
        {
            this.repository = repository; // DI
            this.countryRepository = countryRepository;
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
        //sadas
        [HttpGet]
        public IActionResult Create()
        {
           //var con = countryRepository.GetAll();
            ViewBag.Countries = countryRepository.GetAll();
            ViewData["Title"] = "Create New Department";
            return View();  
        }

        [HttpPost]
        public IActionResult Create(Department model)
        {
            

            ViewBag.Countries = countryRepository.GetAll();

            ModelState.Remove("Country");
            ModelState.Remove("Id");

            if (ModelState.IsValid)
            {
                ViewData["Title"] = "Create New Department";
                Department x = repository.AddDepartment(model);

                //return RedirectToAction("Detail", new { id = x.Id });
            }
            return View();
        }
    }
}
