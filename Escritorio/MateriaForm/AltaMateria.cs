using Entities;
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

namespace Escritorio.MateriaForm
{
    public partial class AltaMateria : Form
    {
        public AltaMateria()
        {
            InitializeComponent();
        }
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };


        private async void AltaMateria_Load(object sender, EventArgs e)
        {
            var planes = await _httpClient.GetFromJsonAsync<IEnumerable<Plan>>("planes");

            comboBox1.DataSource = planes;
            comboBox1.DisplayMember = "Descripcion";
            comboBox1.ValueMember = "Id";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int idPlan = Convert.ToInt32(comboBox1.SelectedValue);


            var plan = new Plan()
            {
                Id = idPlan
            };

            Materia m = new Materia()
            {
                Plan = plan,
                Descripcion = inputMateria.Text,
                HsSemanales = Convert.ToInt32(inputHorasSemanales.Text),
                HsTotales = Convert.ToInt32(inputHorasTotales.Text)

            };

            await _httpClient.PostAsJsonAsync("materias", m);

            this.Dispose();

        }
    }
}
