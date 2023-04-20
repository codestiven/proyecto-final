using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto_final.Datos;
using Proyecto_final.Modelos;

namespace Proyecto_final.Pages.Profesor.categorias
{
    public class exaModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public exaModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public examenes examenes { get; set; }


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {


            if (ModelState.IsValid)
            {
                await _context.examenes.AddAsync(examenes);
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
