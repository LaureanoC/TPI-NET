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

namespace Escritorio.Especialidad
{
    public partial class UpdateEspecialidad : Form
    {
        public int idEsp;

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };
        public UpdateEspecialidad(int id)
        {
            this.idEsp = id;
            InitializeComponent();
        }


        private async void btnModificar_Click(object sender, EventArgs e)
        {
            string desc = inputDesc.Text;

            var especialidad = new Entities.Especialidad()
            {
                Id = idEsp,
                Descripcion = desc
            };

            await _httpClient.PutAsJsonAsync($"especialidades/{idEsp}", especialidad);

            this.Dispose();
        }

        private void UpdateEspecialidad_Load(object sender, EventArgs e)
        {

        }
    }
}
