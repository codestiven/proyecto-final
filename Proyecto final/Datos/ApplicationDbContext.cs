using Microsoft.EntityFrameworkCore;
using Proyecto_final.Modelos;

namespace Proyecto_final.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<profesor> profesors { get; set; }
        public DbSet<examenes> examenes { get; set; }

        
    }
}