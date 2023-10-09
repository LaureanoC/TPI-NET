using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Escritorio.PlanForm
{
    public partial class AltaPlanForm : Form
    {
        public AltaPlanForm()
        {
            InitializeComponent();
        }
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };
        private async void AltaPlanForm_Load(object sender, EventArgs e)
        {
            var especialidades = await _httpClient.GetFromJsonAsync<IEnumerable<Entities.Especialidad>>("especialidades");

            comboEspecialidad.DataSource = especialidades;
            comboEspecialidad.DisplayMember = "Descripcion";
            comboEspecialidad.ValueMember = "Id";

        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            string desc = inputDesc.Text;
            int idEspecialidad = Convert.ToInt32(comboEspecialidad.SelectedValue);

            Entities.Especialidad esp = new Entities.Especialidad() 
            { 
                Id = idEspecialidad
            };

            var plan = new Plan() 
            {
               Descripcion = desc,
               Especialidad = esp
            };

            await _httpClient.PostAsJsonAsync("planes", plan);

            this.Dispose();




        }
    }
}
