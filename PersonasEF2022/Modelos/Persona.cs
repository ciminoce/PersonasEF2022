using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasEF2022.Modelos
{
    [Table("Personas")]
    public class Persona
    {
        public int PersonaId { get; set; }
        [Required]
        [StringLength(50,MinimumLength = 3)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Apellido { get; set; }

        public decimal SueldoNeto { get; set; }
        public bool Activo { get; set; }

    }
}
