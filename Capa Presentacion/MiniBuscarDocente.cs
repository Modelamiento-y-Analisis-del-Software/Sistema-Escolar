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
    public partial class MiniBuscarDocente : Form
    {
        public Docente Doc { get; set; }
        public UserControl usc;
        public CreateCurso uscCreateCurso;
        public MiniBuscarDocente()
        {
            InitializeComponent();
            
        }
        public void listarDocente() { dgvDocen.DataSource = LgcDocente.Instancia.ListarDocente(); }
        public MiniBuscarDocente(CreateCurso usc)
        {
            InitializeComponent();
            listarDocente();
            this.usc = usc;
            uscCreateCurso = usc;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {


            if (usc is CreateTutor)
            {
                if (dgvDocen.CurrentRow != null)
                {
                    Doc = (Docente)dgvDocen.CurrentRow.DataBoundItem;
                }
                uscCreateCurso.txtDocExistSearch.Text = Doc.Dni;
            }
                this.Close();
        }

        private void btnDRefresh_Click(object sender, EventArgs e)
        {
            listarDocente();
        }

        private void txtDSearch_TextChanged(object sender, EventArgs e)
        {
            dgvDocen.DataSource = LgcEstudiante.Instancia.BuscarEstudiante(txtDSearch.Text.Trim());
            txtDSearch.Text = "";
        }
    }
}
