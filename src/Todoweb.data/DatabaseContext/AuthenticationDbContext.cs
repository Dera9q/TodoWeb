using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Todoweb.data.Entities;

namespace Todoweb.data.DatabaseContext
{
    public class AuthenticationDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options)
            : base(options)
        {
            
        }
    }
}