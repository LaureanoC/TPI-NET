using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Plan
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public int IdEspecialidad { get; set; }
        public Especialidad Especialidad { get; set; }

        public ICollection<Persona> Alumnos { get; set; }
    }
}
