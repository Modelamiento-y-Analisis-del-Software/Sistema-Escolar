using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class MiniBuscarEstudiante : Form
    {
        public Estudiante Est { get; set; }
        public UserControl usc;
        public CreateTutor uscCreateTutor;
        public Matricular uscMatricular;
        public MiniBuscarEstudiante()
        {
            InitializeComponent();
            ListarEstudiantes();
        }

        public MiniBuscarEstudiante(CreateTutor usc)
        {
            InitializeComponent();
            ListarEstudiantes();
            this.usc = usc;
            uscCreateTutor = usc;
        }
        public MiniBuscarEstudiante(Matricular usc)
        {
            InitializeComponent();
            ListarEstudiantes();
            this.usc = usc;
            uscMatricular = usc;
        }

        void ListarEstudiantes()
        {
            dgvEstudiantes.DataSource = LgcEstudiante.Instancia.ListarEstudiantesHabilitados();
        }

        private void btnEstRefresh_Click(object sender, EventArgs e)
        {
            ListarEstudiantes();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (usc is Matricular)
            {
                if (dgvEstudiantes.CurrentRow != null)
                {
                    Est = (Estudiante)dgvEstudiantes.CurrentRow.DataBoundItem;
                }
                uscMatricular.txtEstExistSearch.Text = Est.Dni;
                var m = LgcMatricula.Instancia.BuscarMatricula(Est.Id);
                uscMatricular.LoadMatricula(m);
            }
            else if (usc is CreateTutor)
            {
                if (dgvEstudiantes.CurrentRow != null)
                {
                    Est = (Estudiante)dgvEstudiantes.CurrentRow.DataBoundItem;
                }
                uscCreateTutor.txtEstSearch.Text = Est.Dni;
            }
            this.Close();
        }

        private void txtSearch_OnIconRightClick(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = LgcEstudiante.Instancia.BuscarEstudiante(txtSearch.Text.Trim());
            txtSearch.Text = "";
        }
    }
}
