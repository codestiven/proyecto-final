using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proyecto_final.Datos;
using Proyecto_final.Modelos;

namespace Proyecto_final.Pages.Estudiante
{
    public class ExamenModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ExamenModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public examenes examenes { get; set; }


        public async Task OnGet(int Id)
        {
            examenes = await _context.examenes.FindAsync(Id);

            
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CategoriaDesdeDB = await _context.profesors.FindAsync(examenes.codigo);
                CategoriaDesdeDB.Nombre = examenes.Nombre;
                CategoriaDesdeDB.Correo = examenes.pregunta1;
                CategoriaDesdeDB.contraseña = examenes.pregunta2;



                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
