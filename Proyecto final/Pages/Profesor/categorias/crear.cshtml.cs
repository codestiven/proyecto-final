using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto_final.Datos;
using Proyecto_final.Modelos;

namespace proyecto_agenda.Pages.categorias
{
    public class crearModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public crearModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public profesor profesores { get; set; }


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            

            if (ModelState.IsValid)
            {
                await _context.profesors.AddAsync(profesores);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
