using Microsoft.AspNetCore.Mvc;

namespace TodoWeb.web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View(); 
        }
    }
}