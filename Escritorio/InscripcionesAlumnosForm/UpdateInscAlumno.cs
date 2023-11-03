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


            var cursos = await _httpClient.GetFromJsonAsync<IEnumerable<CursoDto>>($"cursos");

            comboCurso.DataSource = cursos;
            comboCurso.DisplayMember = "Descripcion";
            comboCurso.ValueMember = "Id";

            comboCurso.SelectedValue = this.idCurso;



        }


        private async void button1_Click(object sender, EventArgs e)
        {

            try
            {

                var inscripcion = await _httpClient.GetFromJsonAsync<InscripcionAlumnoDto>($"inscripcionesalumnos/{idInscripcion}");

                InscripcionAlumno ia = new InscripcionAlumno()
                {
                    Id = inscripcion.Id,
                    Alumno = new Persona() { Id = inscripcion.IdAlumno },
                    Curso = new Curso() { Id = Convert.ToInt32(comboCurso.SelectedValue) },
                    Nota = inscripcion.Nota,
                    Condicion = inscripcion.Condicion
                };

                var idCurso = Convert.ToInt32(comboCurso.SelectedValue);


                //validar que no esté inscripto
                int idPersona = inscripcion.IdAlumno;
                var estaInscripto = await _httpClient.GetFromJsonAsync<bool>($"inscripcionesalumnosestainscripto/{idCurso}/{idPersona}");

                if (estaInscripto)
                {
                    MessageBox.Show("Ya se encuentra inscripto");

                }
                else
                {

                    //validar que haya cupo

                    var cantidad = await _httpClient.GetFromJsonAsync<int>($"inscripcionesalumnoscantidad/{idCurso}");

                    var curso = await _httpClient.GetFromJsonAsync<Curso>($"cursos/{idCurso}");

                    var cupo = curso.Cupo;

                    if (cantidad < cupo)
                    {
                        await _httpClient.PutAsJsonAsync($"inscripcionesalumnos/{inscripcion.Id}", ia);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("No hay cupo disponible");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese la nota correctamente");
            }




        }
    }
}
