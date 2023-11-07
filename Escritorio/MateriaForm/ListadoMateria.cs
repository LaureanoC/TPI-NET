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

namespace Escritorio.MateriaForm
{
    public partial class ListadoMateria : Form
    {
        public ListadoMateria()
        {
            InitializeComponent();
        }
        public async Task listar()
        {
            var materias = await _httpClient.GetFromJsonAsync<IEnumerable<MateriaDto>>("materias");
            this.dataGridView1.DataSource = materias;
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };


        private async void ListadoMateria_Load(object sender, EventArgs e)
        {
            await listar();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaMateria form = new AltaMateria();
            form.Owner = this;
            form.ShowDialog();
            await listar();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);

                var response = await _httpClient.DeleteAsync($"materias/{id}");

                if (!response.IsSuccessStatusCode) //si no es 200
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                await listar();

            } catch(Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
           try
            {
                int id = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                UpdateMateria form = new UpdateMateria(id);
                form.Owner = this;
                form.ShowDialog();


                await listar();

            } catch( Exception ex )
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            
          try
            {

                int id = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);

                var materia = await _httpClient.GetFromJsonAsync<MateriaDto>($"materias/{id}");


            }
            catch ( Exception ex )
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
            

            

        }
    }
}
