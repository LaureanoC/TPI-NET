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

namespace Escritorio.CursoForm
{
    public partial class AltaForm : Form
    {
        public AltaForm()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };
        private async void AltaForm_Load(object sender, EventArgs e)
        {
            var materias = await _httpClient.GetFromJsonAsync<IEnumerable<Materia>>("materias");

            comboMateria.DataSource = materias;
            comboMateria.DisplayMember = "Descripcion";
            comboMateria.ValueMember = "Id";

            var comisiones = await _httpClient.GetFromJsonAsync<IEnumerable<Comision>>("comisiones");

            comboComision.DataSource = comisiones;
            comboComision.DisplayMember = "Descripcion";
            comboComision.ValueMember = "Id";
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var curso = new Curso()
            {
                Anio = Convert.ToInt32(inputAnio.Text),
                Cupo = Convert.ToInt32(inputCupo.Text),
                Materia = new Materia() { Id = Convert.ToInt32(comboMateria.SelectedValue) },
                Comision = new Comision() { Id = Convert.ToInt32(comboComision.SelectedValue) }

            };

            await _httpClient.PostAsJsonAsync("cursos", curso);

            this.Dispose();
        }
    }
}
