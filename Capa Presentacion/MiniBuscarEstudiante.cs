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
        public CreateTutor uscNewTutor;
        public MiniBuscarEstudiante()
        {
            InitializeComponent();
            ListarEstudiantes();
        }

        public MiniBuscarEstudiante(CreateTutor usc)
        {
            InitializeComponent();
            ListarEstudiantes();
            uscNewTutor = usc;
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
            if (dgvEstudiantes.CurrentRow != null)
            {
                Est = (Estudiante) dgvEstudiantes.CurrentRow.DataBoundItem;
            }
            uscNewTutor.txtEstSearch.Text = Est.Dni;
            this.Close();
        }

        private void txtSearch_OnIconRightClick(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = LgcEstudiante.Instancia.BuscarEstudiante(txtSearch.Text.Trim());
            txtSearch.Text = "";
        }
    }
}
