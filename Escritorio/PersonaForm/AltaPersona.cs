using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Escritorio.PersonaForm
{
    public partial class AltaPersona : Form
    {
        public AltaPersona()
        {
            InitializeComponent();
        }
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        private async void aggBtn_Click(object sender, EventArgs e)
        {
            int idPlan = Convert.ToInt32(inputComboPlan.SelectedValue);

            Plan plan = new Plan()
            {
                Id = idPlan
            };
            Persona persona = new Persona()
            {
                Nombre = inputNombre.Text,
                Apellido = inputApellido.Text,
                Direccion = inputDir.Text,
                Telefono = inputTelefono.Text,
                FechaNacimiento = inputFechaNac.Value,
                Plan = plan,
                Legajo = inputLegajo.Text,
                Email = inputEmail.Text
            };

            await _httpClient.PostAsJsonAsync("personas", persona);

            this.Dispose();
        }

        private async void AltaPersona_Load(object sender, EventArgs e)
        {
            var planes = await _httpClient.GetFromJsonAsync<IEnumerable<Plan>>("planes");

            inputComboPlan.DataSource = planes;
            inputComboPlan.DisplayMember = "Descripcion";
            inputComboPlan.ValueMember = "Id";
        }
    }
}
