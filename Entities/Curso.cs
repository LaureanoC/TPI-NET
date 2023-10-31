using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Curso
    {
        public int Id { get; set; }

        public Materia Materia { get; set; }
        public Comision Comision { get; set; }

        public int Anio { get; set; }

        public int Cupo { get; set; }


        public ICollection<Persona> Personas { get; set; }
    }
}
