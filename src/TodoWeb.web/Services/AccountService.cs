using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Todoweb.data.Entities;
using TodoWeb.web.Interfaces;
using TodoWeb.web.Models;

namespace TodoWeb.web.Services
{
     public class AccountService : IAccountService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public AccountService(
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<ApplicationUser> CreateUserAsync(RegisterModel model)
        {
            if(model is null) throw new ArgumentNullException(message: "Invalid details provided", null);

            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                FullName = model.FullName
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if(!result.Succeeded)
            {
                throw new InvalidOperationException(message: AddErrors(result), null);
            }
            return user;
        }

        private string AddErrors(IdentityResult result)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var error in result.Errors)
            {
                sb.Append(error.Description + " ");
            }
            return sb.ToString();
        }
    }
}