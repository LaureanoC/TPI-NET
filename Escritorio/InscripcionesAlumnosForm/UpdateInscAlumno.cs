using Dtos;
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

namespace Escritorio.InscripcionesAlumnosForm
{
    public partial class UpdateInscAlumno : Form
    {
        private int idInscripcion;
        private int idCurso;
        public UpdateInscAlumno(int idInscripcion, int idCurso)
        {
            this.idInscripcion = idInscripcion;
            this.idCurso = idCurso;
            InitializeComponent();

        }
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };
        private async void UpdateInscAlumno_Load(object sender, EventArgs e)
        {

            var alumno = await _httpClient.GetFromJsonAsync<InscripcionAlumnoDto>($"inscripcionesalumnos/{idInscripcion}");

            legajo.Text = alumno.Legajo;


            var cursos = await _httpClient.GetFromJsonAsync<IEnumerable<InscripcionAlumnoDto>>($"cursospersona/{alumno.IdAlumno}");

            comboCurso.DataSource = cursos;
            comboCurso.DisplayMember = "DescripcionCurso";
            comboCurso.ValueMember = "IdCurso";

            comboCurso.SelectedItem = this.idCurso;



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
