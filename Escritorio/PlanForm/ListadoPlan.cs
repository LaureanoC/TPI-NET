﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Escritorio.Especialidad;

namespace Escritorio.PlanForm
{
    public partial class ListadoPlanForm : Form
    {
        public ListadoPlanForm()
        {
            InitializeComponent();
        }

        public async Task listar()
        {
            var planes = await _httpClient.GetFromJsonAsync<IEnumerable<Plan>>("planes");
            this.dataPlan.DataSource = planes;
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaPlanForm form = new AltaPlanForm();
            form.Owner = this;
            form.ShowDialog();

            await listar();
        }

        private async void ListadoPlan_Load(object sender, EventArgs e)
        {
            await listar();
        }

        private async void elimButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataPlan.SelectedRows[0].Cells[0].Value);

            var planes = await _httpClient.DeleteAsync($"planes/{id}");

            await listar();
        }

        private async void modButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataPlan.SelectedRows[0].Cells[0].Value);

            UpdatePlan formMod = new UpdatePlan(id);
            formMod.Owner = this;
            formMod.ShowDialog();

            await listar();
        }
    }
}
