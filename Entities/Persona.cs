namespace Entities
{
    public class Persona
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

        public Plan Plan { get; set; }

        public ICollection<Curso> Cursos { get; set; }


    }
}