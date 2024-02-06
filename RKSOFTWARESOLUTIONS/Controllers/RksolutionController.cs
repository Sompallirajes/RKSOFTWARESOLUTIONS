using Microsoft.AspNetCore.Mvc;

namespace RKSOFTWARESOLUTIONS.Controllers
{
    public class RksolutionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BioData()
        {
            return View();
        }
    }
}
