using Microsoft.AspNetCore.Mvc;
using WebAppMVC430.Models;

namespace WebAppMVC430.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult CountryStates(int id)
        {
            StateRepo repo=new StateRepo();
           var states=repo.GetSatesByCountry(id);
            return Json(states);
        }
    }
}
