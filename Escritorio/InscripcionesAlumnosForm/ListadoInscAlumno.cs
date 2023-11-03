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
    public partial class ListadoInscAlumno : Form
    {
        public ListadoInscAlumno()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        public async Task listar()
        {
            var insc = await _httpClient.GetFromJsonAsync<IEnumerable<InscripcionAlumnoDto>>("inscripcionesalumnos");
            this.dataGridView1.DataSource = insc;
        }

        private async void ListadoInscAlumno_Load(object sender, EventArgs e)
        {
            await listar();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            AltaInscAlumno form = new AltaInscAlumno();
            form.Owner = this;
            form.ShowDialog();

            await listar();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            RegistrarNotaAlumno form = new RegistrarNotaAlumno();
            form.Owner = this;
            form.ShowDialog();

            await listar();
        }

        private async void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                int idInscripcion = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                int idCurso = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);

                UpdateInscAlumno form = new UpdateInscAlumno(idInscripcion, idCurso);
                form.Owner = this;
                form.ShowDialog();

                await listar();

            } catch(Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idInscripcion = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                await _httpClient.DeleteAsync($"inscripcionesalumnos/{idInscripcion}");

                await listar();


            } catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
            
        }
    }
}
