using Microsoft.AspNetCore.Mvc;
using RKSOFTWARESOLUTIONS.Models;

namespace RKSOFTWARESOLUTIONS.Controllers
{
    public class LoginController : Controller
    {
        private readonly AksharaContext _context;

        // Corrected constructor
        public LoginController(AksharaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Logins = _context.Logins.ToList();
            return View(Logins);

        }
        public IActionResult GetId()
        {
               
            return View();

        }
        public IActionResult Logout()
        {
            return View();
        }
    }
}
