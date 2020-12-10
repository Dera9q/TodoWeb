using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Todoweb.data.Entities;
using TodoWeb.web.Interfaces;
using TodoWeb.web.Models;

namespace TodoWeb.web.Controllers
{
     public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(
            IAccountService accountService,
            SignInManager<ApplicationUser> signInManager)
        {
            _accountService = accountService;
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return LocalRedirect("~/");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {

            if(!ModelState.IsValid) return View();

            try
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
                if(!result.Succeeded)
                {
                    ModelState.AddModelError("", "Login failed, please check your details");
                    return View();
                }
                return LocalRedirect("~/");
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }
         
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if(!ModelState.IsValid) return View();

            try
            {
                var user = await _accountService.CreateUserAsync(model);
                await _signInManager.SignInAsync(user, isPersistent: false);
                return LocalRedirect("~/");
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }
            
        }
    }
}