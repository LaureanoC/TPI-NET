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

namespace Escritorio.PlanForm
{
    public partial class UpdatePlan : Form
    {
        int idPlan;
        public UpdatePlan(int id)
        {
            InitializeComponent();
            this.idPlan = id;
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        private async void button1_Click(object sender, EventArgs e)
        {
            string desc = inputDesc.Text;

            int idEspecialidad = Convert.ToInt32(comboEspecialidad.SelectedValue);

            Entities.Especialidad esp = new Entities.Especialidad()
            {
                Id = idEspecialidad
            };

            var plan = new Plan()
            {
                Id = idPlan,
                Descripcion = desc,
                Especialidad = esp
            };

            await _httpClient.PutAsJsonAsync($"planes/{idPlan}", plan);

            this.Dispose();
        }

        private async void UpdatePlan_Load(object sender, EventArgs e)
        {
            var especialidades = await _httpClient.GetFromJsonAsync<IEnumerable<Entities.Especialidad>>("especialidades");

            comboEspecialidad.DataSource = especialidades;
            comboEspecialidad.DisplayMember = "Descripcion";
            comboEspecialidad.ValueMember = "Id";
        }
    }
}
