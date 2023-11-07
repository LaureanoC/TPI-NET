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

namespace Escritorio.ComisionForm
{
    public partial class ListadoComision : Form
    {
        public ListadoComision()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };
        public async Task listar()
        {
            var comisiones = await _httpClient.GetFromJsonAsync<IEnumerable<ComisionDto>>("comisiones");
            this.dataGridView1.DataSource = comisiones;
        }

        private async void ListadoComision_Load(object sender, EventArgs e)
        {
            await listar();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaComision form = new AltaComision();
            form.Owner = this;
            form.ShowDialog();

            await listar();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);

                UpdateComision form = new UpdateComision(id);
                form.Owner = this;
                form.ShowDialog();

                await listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
            }

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);

                var comision = await _httpClient.DeleteAsync($"comisiones/{id}");

                if (!comision.IsSuccessStatusCode) //si no es 200
                {
                    MessageBox.Show(await comision.Content.ReadAsStringAsync());
                }

                await listar();
            } 
            
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
    }
}
