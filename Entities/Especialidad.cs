using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Especialidad
    {
        public int Id { get; set; }
        public string Descripcion{ get; set; }

        public ICollection<Plan> Planes { get; set; }
    }
}
