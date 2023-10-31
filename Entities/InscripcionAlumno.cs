using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InscripcionAlumno
    { 
        public int Id { get; set; }
        public Persona Alumno { get; set; }

        public Curso Curso { get; set; }

        public string Condicion { get; set; }

        public double ?Nota { get; set; }


    }
}
