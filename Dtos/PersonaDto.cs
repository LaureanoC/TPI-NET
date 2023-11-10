using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class PersonaDto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string TipoPersona { get; set; }

        public string Legajo { get; set; }

       public string PlanDesc { get; set; }
    }
}
