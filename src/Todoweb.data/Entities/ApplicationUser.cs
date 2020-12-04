using Microsoft.AspNetCore.Identity;

namespace Todoweb.data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}