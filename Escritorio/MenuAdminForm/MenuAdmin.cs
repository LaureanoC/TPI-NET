using Escritorio.ComisionForm;
using Escritorio.CursoForm;
using Escritorio.Especialidad;
using Escritorio.InscripcionesAlumnosForm;
using Escritorio.MateriaForm;
using Escritorio.PersonaForm;
using Escritorio.PlanForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.MenuAdminForm
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListadoPersona form = new ListadoPersona();
            form.Owner = this;
            form.ShowDialog();
        }

        private void espBtn_Click(object sender, EventArgs e)
        {
            ListadoEspecialidadForm form = new ListadoEspecialidadForm();
            form.Owner = this;
            form.ShowDialog();
        }

        private void planBtn_Click(object sender, EventArgs e)
        {
            ListadoPlanForm form = new ListadoPlanForm();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            ListadoMateria form = new ListadoMateria();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnComision_Click(object sender, EventArgs e)
        {
            ListadoComision form = new ListadoComision();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            ListadoCurso form = new ListadoCurso();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnIAlumno_Click(object sender, EventArgs e)
        {
            ListadoInscAlumno form = new ListadoInscAlumno();
            form.Owner = this;
            form.ShowDialog();

        }
    }
}
