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

            Plan plan = new Plan()
            {
                Id = idPlan
            };

            Persona persona = new Persona()
            {
                Id = this.id,
                Nombre = inputNombre.Text,
                Apellido = inputApellido.Text,
                Direccion = inputDir.Text,
                Telefono = inputTelefono.Text,
                FechaNacimiento = inputFechaNac.Value,
                Plan = plan,
                Legajo = inputLegajo.Text,
                Email = inputEmail.Text,
                TipoPersona = inputTipo.Text
            };

            await _httpClient.PutAsJsonAsync($"personas/{id}", persona);

            this.Dispose();
        }

        private async void UpdatePersona_Load(object sender, EventArgs e)
        {

            var persona = await _httpClient.GetFromJsonAsync<Persona>($"personas/{id}");


            var planes = await _httpClient.GetFromJsonAsync<IEnumerable<Plan>>("planes");


            inputComboPlan.DataSource = planes;
            inputComboPlan.DisplayMember = "Descripcion";
            inputComboPlan.ValueMember = "Id";

            inputComboPlan.SelectedValue = persona.Plan.Id;

            inputNombre.Text = persona.Nombre;
            inputApellido.Text = persona.Apellido;
            inputDir.Text = persona.Direccion;
            inputEmail.Text = persona.Email;
            inputFechaNac.Value = persona.FechaNacimiento;
            inputTelefono.Text = persona.Telefono;
            inputLegajo.Text = persona.Legajo;

            inputTipo.SelectedIndex = 0;

        }
    }
}
