using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InscripcionProfesor
    {
        public int Id { get; set; }

        public Persona Profesor { get; set; }

        public Curso Curso { get; set; }

        public string Cargo { get; set; }
    }
}
