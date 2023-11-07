using Dtos;
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
    public partial class ListadoCurso : Form
    {
        public ListadoCurso()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        public async void listar()
        {
            var cursos = await _httpClient.GetFromJsonAsync<IEnumerable<CursoDto>>("cursos");
            this.dataGridView1.DataSource = cursos;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AltaForm form = new AltaForm();
            form.Owner = this;
            form.ShowDialog();

            listar();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                UpdateCurso form = new UpdateCurso(id);
                form.Owner = this;
                form.ShowDialog();

                listar();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
            
            
        }

        private void ListadoCurso_Load(object sender, EventArgs e)
        {
            listar();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            
            try
            {

                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                var response = await _httpClient.DeleteAsync($"cursos/{id}");

                if (!response.IsSuccessStatusCode) //si no es 200
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }
                listar();

            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
            
        }
    }
}
