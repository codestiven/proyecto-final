using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proyecto_final.Datos;
using Proyecto_final.Modelos;

namespace proyecto_agenda.Pages.categorias
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<profesor> profesores { get; set; }

        public async Task OnGet()
        {
            profesores = await _context.profesors.ToListAsync();

        }
    }
}
