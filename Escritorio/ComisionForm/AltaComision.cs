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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Escritorio.ComisionForm
{
    public partial class AltaComision : Form
    {
        public AltaComision()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };




        private async void button1_Click(object sender, EventArgs e)
        {
            Plan p = new Plan();

            p.Id = Convert.ToInt32(comboPlan.SelectedValue); ;

            var c = new Comision()
            {
                Descripcion = inputDesc.Text,
                Anio = Convert.ToInt32(inputAnio.Text),
                Plan = p
            };

            await _httpClient.PostAsJsonAsync("comisiones", c);

            this.Dispose();
        }

        private async void AltaComision_Load(object sender, EventArgs e)
        {
            var planes = await _httpClient.GetFromJsonAsync<IEnumerable<Plan>>("planes");

            comboPlan.DataSource = planes;
            comboPlan.DisplayMember = "Descripcion";
            comboPlan.ValueMember = "Id";
        }

       
    }
}
