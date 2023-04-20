using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_final.Modelos
{
    public class profesor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "algun dia este mensaje aparecera en alguna parte")]
        [StringLength(20, ErrorMessage = "{0} MUY CORTO PENDEJO {1} Y {2}", MinimumLength = 3)]
        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string contraseña { get; set; }


    }
}
