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
    public partial class UpdateInscProfesor : Form
    {
        private int idInscripcion;
        private int idCurso;
        public UpdateInscProfesor(int idInscripcion, int idCurso)
        {
            this.idInscripcion = idInscripcion;
            this.idCurso = idCurso;
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        private async void UpdateInscProfesor_Load(object sender, EventArgs e)
        {
            var profesor = await _httpClient.GetFromJsonAsync<InscripcionProfesorDto>($"inscripcionesprofesor/{idInscripcion}");

            legajo.Text = profesor.Legajo;
            inputCargo.Text = profesor.Cargo;


            var cursos = await _httpClient.GetFromJsonAsync<IEnumerable<CursoDto>>($"cursos");

            inputCurso.DataSource = cursos;
            inputCurso.DisplayMember = "Descripcion";
            inputCurso.ValueMember = "Id";

            inputCurso.SelectedValue = this.idCurso;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var inscripcion = await _httpClient.GetFromJsonAsync<InscripcionProfesorDto>($"inscripcionesprofesor/{idInscripcion}");

            InscripcionProfesor ip = new InscripcionProfesor()
            {
                Id = inscripcion.Id,
                Profesor = new Persona() { Id = inscripcion.IdProfesor },
                Curso = new Curso() { Id = Convert.ToInt32(inputCurso.SelectedValue) },
                Cargo = inputCargo.Text
            };

            var idCurso = Convert.ToInt32(inputCurso.SelectedValue);


            //validar que no esté inscripto
            int idPersona = inscripcion.IdProfesor;
            var estaInscripto = await _httpClient.GetFromJsonAsync<bool>($"inscripcionesprofesorestainscripto/{idCurso}/{idPersona}");

            if (estaInscripto)
            {
                MessageBox.Show("Ya se encuentra inscripto");

            } else
            {
                await _httpClient.PutAsJsonAsync($"inscripcionesprofesor/{idInscripcion}",ip);
                this.Dispose();
            }
        }
    }
}
