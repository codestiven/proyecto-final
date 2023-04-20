using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto_final.Datos;
using Proyecto_final.Modelos;

namespace proyecto_agenda.Pages.categorias
{
    public class editarModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public editarModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public profesor profesores { get; set; }


        public async void OnGet( int Id)
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
                CategoriaDesdeDB.contrase�a = profesores.contrase�a;


    
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
