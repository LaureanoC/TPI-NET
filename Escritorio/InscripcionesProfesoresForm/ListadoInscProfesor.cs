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

namespace Escritorio.InscripcionesProfesoresForm
{
    public partial class ListadoInscProfesor : Form
    {
        public ListadoInscProfesor()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        public async Task listar()
        {
            var insc = await _httpClient.GetFromJsonAsync<IEnumerable<InscripcionProfesorDto>>("inscripcionesprofesor");
            this.dataGridView1.DataSource = insc;
        }


        private async void ListadoInscProfesor_Load(object sender, EventArgs e)
        {
            await listar();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            AltaInscProfesor form = new AltaInscProfesor();
            form.Owner = this;
            form.ShowDialog();

            await listar();
        }

        private async void btnElim_Click(object sender, EventArgs e)
        {
            try
            {
                int idInscripcion = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                await _httpClient.DeleteAsync($"inscripcionesprofesor/{idInscripcion}");

                await listar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private async void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                int idInscripcion = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                int idCurso = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);

                UpdateInscProfesor form = new UpdateInscProfesor(idInscripcion, idCurso);
                form.Owner = this;
                form.ShowDialog();

                await listar();

            } catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
            

        }
    }
}
