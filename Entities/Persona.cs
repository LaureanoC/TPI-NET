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

        public int TipoPersona { get; set; }

        public string Legajo { get; set; }

        public int IdPlan { get; set; }

        public Plan Plan { get; set; }


    }
}