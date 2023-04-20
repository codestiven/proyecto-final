using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_final.Modelos
{
    public class examenes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "algun dia este mensaje aparecera en alguna parte")]
        [StringLength(20, ErrorMessage = "{0} MUY CORTO PENDEJO {1} Y {2}", MinimumLength = 3)]
        public string Nombre { get; set; }

        public string codigo { get; set; }

        public string pregunta1 { get; set; }

        public string pregunta2 { get; set; }

        public string pregunta3 { get; set; }

        public static implicit operator examenes(List<examenes> v)
        {
            throw new NotImplementedException();
        }
    }
}
