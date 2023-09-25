using Entities;
using System.Net.Http.Json;

namespace Escritorio
{
    public partial class AltaEspecialidadForm : Form
    {
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        public AltaEspecialidadForm()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = inputDesc.Text;

            var esp = new Entities.Especialidad()
            {
                Descripcion = descripcion
            };

            await _httpClient.PostAsJsonAsync("especialidades", esp);

            this.Dispose();


        }
    }
}