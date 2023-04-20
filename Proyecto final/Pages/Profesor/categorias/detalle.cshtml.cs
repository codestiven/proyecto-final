using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto_final.Datos;
using Proyecto_final.Modelos;

namespace proyecto_agenda.Pages.categorias
{
    public class detalleModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public detalleModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public profesor profesores { get; set; }


        public async void OnGet(int Id)
        {
            profesores = await _context.profesors.FindAsync(Id);
        }
    }
}
