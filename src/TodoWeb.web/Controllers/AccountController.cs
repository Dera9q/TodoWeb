using System;
using Microsoft.AspNetCore.Mvc;
using TodoWeb.web.Models;

namespace TodoWeb.web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if(!ModelState.IsValid) return View();
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if(!ModelState.IsValid) return View();
            throw new NotImplementedException();
        }
    }
}