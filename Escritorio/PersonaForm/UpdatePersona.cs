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

namespace Escritorio.PersonaForm
{
    public partial class UpdatePersona : Form
    {
        int id;
        public UpdatePersona(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        private async void modBtn_Click(object sender, EventArgs e)
        {
            int idPlan = Convert.ToInt32(inputComboPlan.SelectedValue);
            Persona persona = new Persona()
            {
                Id = this.id,
                Nombre = inputNombre.Text,
                Apellido = inputApellido.Text,
                Direccion = inputDir.Text,
                Telefono = inputTelefono.Text,
                FechaNacimiento = inputFechaNac.Value,
                IdPlan = idPlan,
                Legajo = inputLegajo.Text,
                Email = inputEmail.Text
            };

            await _httpClient.PutAsJsonAsync($"personas/{idPlan}", persona);

            this.Dispose();
        }

        private async void UpdatePersona_Load(object sender, EventArgs e)
        {
            var planes = await _httpClient.GetFromJsonAsync<IEnumerable<Plan>>("planes");

            inputComboPlan.DataSource = planes;
            inputComboPlan.DisplayMember = "Descripcion";
            inputComboPlan.ValueMember = "Id";
        }
    }
}
