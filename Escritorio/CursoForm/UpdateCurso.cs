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

namespace Escritorio.CursoForm
{
    public partial class UpdateCurso : Form
    {
        private int id;
        public UpdateCurso(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        private async void UpdateCurso_Load(object sender, EventArgs e)
        {
            var curso = await _httpClient.GetFromJsonAsync<Curso>($"cursos/{this.id}");


            var materias = await _httpClient.GetFromJsonAsync<IEnumerable<Materia>>("materias");

            comboMateria.DataSource = materias;
            comboMateria.DisplayMember = "Descripcion";
            comboMateria.ValueMember = "Id";


            var materia = await _httpClient.GetFromJsonAsync<Materia>($"materias/{curso.Materia.Id}");

            comboMateria.SelectedValue = materia.Id;



            var comisiones = await _httpClient.GetFromJsonAsync<IEnumerable<Comision>>("comisiones");

            comboComision.DataSource = comisiones;
            comboComision.DisplayMember = "Descripcion";
            comboComision.ValueMember = "Id";

            var comision = await _httpClient.GetFromJsonAsync<Comision>($"comisiones/{curso.Comision.Id}");

            comboComision.SelectedValue = comision.Id;


            inputAnio.Text = curso.Anio.ToString();
            inputCupo.Text = curso.Cupo.ToString();

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                Curso c = new Curso()
                {
                    Anio = Convert.ToInt32(inputAnio.Text),
                    Cupo = Convert.ToInt32(inputCupo.Text),
                    Materia = new Materia() { Id = Convert.ToInt32(comboMateria.SelectedValue) },
                    Comision = new Comision() { Id = Convert.ToInt32(comboComision.SelectedValue) }
                };

                await _httpClient.PutAsJsonAsync($"cursos/{id}", c);

                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese correctamente el año y cupo.");
            }


        }
    }
}
