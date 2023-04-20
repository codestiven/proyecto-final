using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto_final.Datos;
using Proyecto_final.Modelos;

namespace Proyecto_final.Pages.Profesor.categorias
{
    public class borrarModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public borrarModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public profesor profesores { get; set; }


        public async void OnGet(int Id)
        {
            profesores = await _context.profesors.FindAsync(Id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CategoriaDesdeDB = await _context.profesors.FindAsync(profesores.Id);
                CategoriaDesdeDB.Nombre = profesores.Nombre;
                CategoriaDesdeDB.Correo = profesores.Correo;
                CategoriaDesdeDB.contraseña = profesores.contraseña;



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
