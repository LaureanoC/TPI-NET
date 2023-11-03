using Entities;
using Escritorio.PlanForm;
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

namespace Escritorio.PersonaForm
{
    public partial class ListadoPersona : Form
    {
        public ListadoPersona()
        {
            InitializeComponent();
        }

        public async Task listar()
        {
            var personas = await _httpClient.GetFromJsonAsync<IEnumerable<Persona>>("personas");
            this.dataPersona.DataSource = personas;
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        private async void ListadoPersona_Load(object sender, EventArgs e)
        {
            await listar();
        }

        private async void agregarBtn_Click(object sender, EventArgs e)
        {
            AltaPersona form = new AltaPersona();
            form.Owner = this;
            form.ShowDialog();

            await listar();
        }

        private async void modBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.dataPersona.SelectedRows[0].Cells[0].Value);

                UpdatePersona formMod = new UpdatePersona(id);
                formMod.Owner = this;
                formMod.ShowDialog();

                await listar();

            } catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private async void elimBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.dataPersona.SelectedRows[0].Cells[0].Value);

                var especialidad = await _httpClient.DeleteAsync($"personas/{id}");

                await listar();
            
            } catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
            }
    }
}
