using Microsoft.EntityFrameworkCore;
using Todoweb.data.Entities;

namespace Todoweb.data.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
         {

         }

         public DbSet<Todolist> Todolist {get; set;}
    }
}