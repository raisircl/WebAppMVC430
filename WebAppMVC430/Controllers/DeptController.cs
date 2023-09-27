using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebAppMVC430.Models;
using WebAppMVC430.Models.ViewModels;

namespace WebAppMVC430.Controllers
{
    public class DeptController : Controller
    {
        private readonly IDepartmentRepository repository;
        private readonly ICountryRepository countryRepository;
        private readonly IWebHostEnvironment hostingEnvironment;

        public DeptController(IDepartmentRepository repository, ICountryRepository countryRepository, IWebHostEnvironment hostingEnvironment)
        {
            this.repository = repository; // DI
            this.countryRepository = countryRepository;
            this.hostingEnvironment = hostingEnvironment;
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
        public IActionResult Create(DepartmentCreateViewModel model)
        {
            string uniquefilename = "";

            ViewBag.Countries = countryRepository.GetAll();

            ModelState.Remove("Country");
            ModelState.Remove("Id");

            if (ModelState.IsValid)
            {
                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.

                if (model.CoverImage!=null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    // to get the wwwroot folder path
                    string uploadfolder = Path.Combine(hostingEnvironment.WebRootPath, "images");

                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniquefilename = Guid.NewGuid().ToString() + "_" + model.CoverImage.FileName;
                    string filepath = Path.Combine(uploadfolder, uniquefilename);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.CoverImage.CopyTo(new FileStream(filepath, FileMode.Create));


                }
                ViewData["Title"] = "Create New Department";

                Department x = new Department()
                {
                    Id = model.Id,  
                    DName = model.DName,
                    Loc=model.Loc,
                    SId = model.SId,    
                    CId = model.CId,    
                    CoverImage=uniquefilename
                };
                repository.AddDepartment(x);    
                return RedirectToAction("Detail", new { id = x.Id });
            }
            return View();
        }
    }
}
