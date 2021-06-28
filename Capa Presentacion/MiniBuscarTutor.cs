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
    public partial class MiniBuscarTutor : Form
    {
        Tutor EntidadTutor { get; set; }
        Matricular uscMatricular;

        public MiniBuscarTutor()
        {
            InitializeComponent();
            ListarTutores();
        }

        public MiniBuscarTutor(Matricular usrMatricular)
        {
            InitializeComponent();
            ListarTutores();
            this.uscMatricular = usrMatricular;
        }

        void ListarTutores ()
        {
            dgvTutores.DataSource = LgcTutor.Instancia.ListarTutores();
        }

        private void txtTutSearch_OnIconRightClick(object sender, EventArgs e)
        {
            dgvTutores.DataSource = LgcTutor.Instancia.SearchTutor(txtTutSearch.Text.Trim());
        }

        private void btnEstRefresh_Click(object sender, EventArgs e)
        {
            ListarTutores();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvTutores.CurrentRow != null)
            {
                EntidadTutor = (Tutor) dgvTutores.CurrentRow.DataBoundItem;
            }
            uscMatricular.txtTutSearch.Text = EntidadTutor.Dni;
            this.Close();
        }
    }
}
