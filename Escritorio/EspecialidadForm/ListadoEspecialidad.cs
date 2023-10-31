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
using Entities;

namespace Escritorio.Especialidad
{
    public partial class ListadoEspecialidadForm : Form
    {
        public ListadoEspecialidadForm()
        {
            InitializeComponent();
        }

        public async Task listar()
        {
            var especialidades = await _httpClient.GetFromJsonAsync<IEnumerable<Entities.Especialidad>>("especialidades");
            this.dataEspecialidad.DataSource = especialidades;
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaEspecialidadForm form = new AltaEspecialidadForm();
            form.Owner = this;
            form.ShowDialog();

            await listar();

        }

        private async void ListadoEspecialidadForm_Load(object sender, EventArgs e)
        {
            await listar();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataEspecialidad.SelectedRows[0].Cells[0].Value);

            var especialidad = await _httpClient.DeleteAsync($"especialidades/{id}");

            await listar();


        }

        private async void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataEspecialidad.SelectedRows[0].Cells[0].Value);

            UpdateEspecialidad formMod = new UpdateEspecialidad(id);
            formMod.Owner = this;
            formMod.ShowDialog();

            await listar();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            
            var descripcion = this.dataEspecialidad.SelectedRows[0].Cells[1].Value;

            MessageBox.Show("Especialidad: " + descripcion);
        }
    }
}
