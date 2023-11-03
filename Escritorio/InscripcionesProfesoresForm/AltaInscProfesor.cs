using Dtos;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.InscripcionesProfesoresForm
{
    public partial class AltaInscProfesor : Form
    {
        public AltaInscProfesor()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        private async void AltaInscProfesor_Load(object sender, EventArgs e)
        {
            var profesores = await _httpClient.GetFromJsonAsync<IEnumerable<Persona>>("profesores");

            inputLegajo.DataSource = profesores;
            inputLegajo.DisplayMember = "Legajo";
            inputLegajo.ValueMember = "Id";


            var cursos = await _httpClient.GetFromJsonAsync<IEnumerable<CursoDto>>("cursos");

            inputCurso.DataSource = cursos;
            inputCurso.DisplayMember = "Descripcion";
            inputCurso.ValueMember = "Id";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            InscripcionProfesor ip = new InscripcionProfesor()
            {
                Profesor = new Persona() { Id = Convert.ToInt32(inputLegajo.SelectedValue) },
                Curso = new Curso() { Id = Convert.ToInt32(inputCurso.SelectedValue) },
                Cargo = inputCargo.Text
            };

            //Validar que no esté inscripto
            int idCurso = Convert.ToInt32(inputCurso.SelectedValue);
            int idPersona = Convert.ToInt32(inputLegajo.SelectedValue);
            var estaInscripto = await _httpClient.GetFromJsonAsync<bool>($"inscripcionesprofesorestainscripto/{idCurso}/{idPersona}");

            if (estaInscripto)
            {
                MessageBox.Show("Ya se encuentra inscripto");

            }
            else
            {
                await _httpClient.PostAsJsonAsync("inscripcionesprofesor", ip);

                this.Dispose();
            }

        }
    }
}
