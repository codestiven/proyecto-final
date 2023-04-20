using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto_final.Datos;
using Proyecto_final.Modelos;

namespace Proyecto_final.Pages.Estudiante
{
    public class registroModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public registroModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public profesor profesor { get; set; }


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _context.profesors.AddAsync(profesor);
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
