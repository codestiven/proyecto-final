using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proyecto_final.Datos;
using Proyecto_final.Modelos;



namespace Proyecto_final.Pages.Profesor
{
    public class registroModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public registroModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public profesor profesores { get; set; }


        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            /*  byte[] bytdees = null;

              if (profesores != null) { 

                  using(Stream fs = profesores.Imagen.OpenReadStream())
                  {
                      using(BinaryReader br = new BinaryReader(fs))
                      {
                       bytdees = br.ReadBytes((Int32)fs.Length);
                      }
                  }


              }
              profesores.Imagen = Convert.ToBase64String(bytdees, 0, bytdees.Length); 

            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), profesores.Imagen.FileName);
            using var stream = new FileStream(fullPath, FileMode.Create);
            await profesores.Imagen.CopyToAsync(stream); */









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
