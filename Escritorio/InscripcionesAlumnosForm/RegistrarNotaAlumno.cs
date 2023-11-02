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
    public partial class RegistrarNotaAlumno : Form
    {
        public RegistrarNotaAlumno()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };


        private async void RegistrarNotaAlumno_Load(object sender, EventArgs e)
        {

            comboCurso.Enabled = false;

            var alumnos = await _httpClient.GetFromJsonAsync<IEnumerable<Persona>>("alumnos");

            comboAlumno.DataSource = alumnos;
            comboAlumno.DisplayMember = "Legajo";
            comboAlumno.ValueMember = "Id";

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idPersona = Convert.ToInt32(comboAlumno.SelectedValue);
                int idCurso = Convert.ToInt32(comboCurso.SelectedValue);
               
                var inscripcion = await _httpClient.GetFromJsonAsync<InscripcionAlumno>($"inscripcionesalumnoscurso/{idCurso}/{idPersona}");

                InscripcionAlumno insc = new InscripcionAlumno()
                {
                    Id = inscripcion.Id,
                    Alumno = new Persona() { Id = Convert.ToInt32(comboAlumno.SelectedValue) },
                    Curso = new Curso() { Id = Convert.ToInt32(comboCurso.SelectedValue) },
                    Nota = Convert.ToDouble(inputNota.Text),
                    Condicion = CondicionAlumno(Convert.ToDouble(inputNota.Text))
                };

                if (inscripcion != null)
                {
                    await _httpClient.PutAsJsonAsync($"inscripcionesalumnos/{inscripcion.Id}", insc);
                }

                this.Dispose();
            } catch(Exception ex) 
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            

            

        }

        private string CondicionAlumno(double nota)
        {
            if (nota > 6)
            {
                return "Aprobado";
            }

            return "Desaprobado";
        }

        private async void comboAlumno_DropDownClosed(object sender, EventArgs e)
        {
            comboCurso.Enabled = false;

            comboCurso.DataSource = null;

            int idPersona = Convert.ToInt32(comboAlumno.SelectedValue);
            var cursos = await _httpClient.GetFromJsonAsync<IEnumerable<InscripcionAlumnoDto>>($"cursospersona/{idPersona}");

            if (cursos.Count() != 0)
            {
                comboCurso.Enabled = true;

                comboCurso.DataSource = cursos;
                comboCurso.DisplayMember = "DescripcionCurso";
                comboCurso.ValueMember = "IdCurso";
            }
            

        }
    }
}
