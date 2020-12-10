using System.Threading.Tasks;
using Todoweb.data.Entities;
using TodoWeb.web.Models;

namespace TodoWeb.web.Interfaces
{
    public interface IAccountService
    {
        Task<ApplicationUser> CreateUserAsync(RegisterModel model);
    }
}