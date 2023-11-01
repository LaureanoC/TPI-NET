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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Escritorio.InscripcionesAlumnosForm
{
    public partial class AltaInscAlumno : Form
    {
        public AltaInscAlumno()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        private async void AltaInscAlumno_Load(object sender, EventArgs e)
        {
            var alumnos = await _httpClient.GetFromJsonAsync<IEnumerable<Persona>>("alumnos");

            comboAlumno.DataSource = alumnos;
            comboAlumno.DisplayMember = "Legajo";
            comboAlumno.ValueMember = "Id";


            var cursos = await _httpClient.GetFromJsonAsync<IEnumerable<CursoDto>>("cursos");

            comboCurso.DataSource = cursos;
            comboCurso.DisplayMember = "Año";
            comboCurso.ValueMember = "Id";



        }

    

        private async void button1_Click(object sender, EventArgs e)
        {
            InscripcionAlumno ia = new InscripcionAlumno()
            {
                Alumno = new Persona() { Id = Convert.ToInt32(comboAlumno.SelectedValue) },
                Curso = new Curso() { Id = Convert.ToInt32(comboCurso.SelectedValue) },
                Condicion = "Inscripto",
                Nota = null,
            };

            //validar que haya cupo
            int idCurso = Convert.ToInt32(comboCurso.SelectedValue);

            var curso = await _httpClient.GetFromJsonAsync<Curso>($"cursos/{idCurso}");

            var cupo = curso.Cupo;

            var cantidad = await _httpClient.GetFromJsonAsync<int>($"inscripcionesalumnoscantidad/{idCurso}");

            

            if ( cantidad < cupo )
            {
                await _httpClient.PostAsJsonAsync("inscripcionesalumnos", ia);
            } else
            {
                MessageBox.Show("No hay cupo disponible");
            }

            

            this.Dispose();


        }
    }
}
