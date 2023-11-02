using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class InscripcionAlumnoDto
    {
        public int Id { get; set; }

        public int IdAlumno { get; set; }
        public string Legajo { get; set; }

        public string DescripcionCurso { get; set; }
        public int AñoCurso { get; set; }

        public int IdCurso { get; set; }

        public string Condicion { get; set; }

        public double ?Nota { get; set; }
    }
}
