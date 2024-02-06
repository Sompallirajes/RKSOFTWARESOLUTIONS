using Microsoft.AspNetCore.Mvc;

namespace RKSOFTWARESOLUTIONS.Controllers
{
    public class RegistrationFormController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
