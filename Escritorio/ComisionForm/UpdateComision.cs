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

namespace Escritorio.ComisionForm
{
    public partial class UpdateComision : Form
    {
        public UpdateComision(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private int id;

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        private async void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Plan p = new Plan()
                {
                    Id = Convert.ToInt32(comboPlan.SelectedValue)
                };

                Comision c = new Comision()
                {
                    Descripcion = inputDesc.Text,
                    Anio = Convert.ToInt32(inputAnio.Text),
                    Plan = p
                };

                await _httpClient.PutAsJsonAsync($"comisiones/{this.id}", c);

                this.Dispose();
            } catch (Exception ex)
            {
                MessageBox.Show("Ingrese el año correctamente");

            }
            
        }

        private async void UpdateComision_Load(object sender, EventArgs e)
        {
           
            var comision = await _httpClient.GetFromJsonAsync<Comision>($"comisiones/{this.id}");

            var planes = await _httpClient.GetFromJsonAsync<IEnumerable<Plan>>("planes");

            comboPlan.DataSource = planes;
            comboPlan.DisplayMember = "Descripcion";
            comboPlan.ValueMember = "Id";

            comboPlan.SelectedValue = comision.Plan.Id;
            
            inputAnio.Text = comision.Anio.ToString();
            inputDesc.Text = comision.Descripcion;




        }
    }
}
