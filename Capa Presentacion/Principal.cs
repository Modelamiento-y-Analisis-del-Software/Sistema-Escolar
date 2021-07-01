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
using KimtToo.VisualReactive;

namespace CapaPresentacion
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
            frmSubMenu1.MainWindow = this;
            uscMatricular.MainWindow = this;
        }

        bool mnuExpanded = false;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!menuTransition.IsCompleted) return;
            if (pnlMainMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!mnuExpanded)
                {
                    mnuExpanded = true;
                    pnlMainMenu.Width = 250;
                }
            }
            else
            {
                if (mnuExpanded)
                {
                    mnuExpanded = false;
                    pnlMainMenu.Width = 55;
                    menuTransition.Show(pnlMainMenu);
                }
            }

        }

        public void ListarEstudiantesHabilitados()
        {
            dgvEstudiantes.DataSource = LgcEstudiante.Instancia.ListarEstudiantesHabilitados();
        }

        public void ListarTutores()
        {
            dgvTutor.DataSource = LgcTutor.Instancia.ListarTutores();
        }

        private void SideMenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            //pagCentral.SetPage("DocGeneral");
        }

        private void BtnTutor_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            PagCentral.SetPage("TutGeneral");
            ListarTutores();
        }
        private void btnCursos_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            PagCentral.SetPage("TutGeneral");
        }

        private void BtnEstudiante_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            PagCentral.SetPage("EstGeneral");
            ListarEstudiantesHabilitados();
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            PagCentral.SetPage("AulGeneral");
        }

        private void txtSearchEst_OnIconRightClick(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = LgcEstudiante.Instancia.BuscarEstudiante(txtSearchEst.Text.ToString());
            txtSearchEst.Text = "";
        }

        private void btnRefreshEst_Click(object sender, EventArgs e)
        {
            txtSearchEst.Text = "";
            ListarEstudiantesHabilitados();
        }

        private void btnEstDetalle_Click(object sender, EventArgs e)
        {
            CapaEntidad.Estudiante est;
            if (dgvEstudiantes.CurrentRow != null)
            {
                est = (CapaEntidad.Estudiante)dgvEstudiantes.CurrentRow.DataBoundItem;
                Matricula m = LgcMatricula.Instancia.BuscarMatricula(est.Id);
                var ed = new EstudianteDetalle(m);
                ed.Show();
            }
        }

        private void btnTutRefresh_Click(object sender, EventArgs e)
        {
            txtTutSearch.Text = "";
            ListarTutores();
        }

        private void txtTutSearch_OnIconRightClick(object sender, EventArgs e)
        {
            dgvTutor.DataSource = LgcTutor.Instancia.SearchTutor(txtTutSearch.Text.ToString().Trim());
            txtTutSearch.Text = "";
        }

        private void btnEstInhabiltar_Click(object sender, EventArgs e)
        {
            Estudiante est;
            if (dgvEstudiantes.CurrentRow != null)
            {
                est = (Estudiante) dgvEstudiantes.CurrentRow.DataBoundItem;
                Matricula m = LgcMatricula.Instancia.BuscarMatricula(est.Id);
                LgcMatricula.Instancia.CambiarEstadoMatricula(m);
                ListarEstudiantesHabilitados();
            }
        }

        private void btnEstInRefresh_Click(object sender, EventArgs e)
        {
            ListarEstudiantesInHabilitados();
            txtEstInSearch.Text = "";
        }

        private void btnEstInDatalles_Click(object sender, EventArgs e)
        {
            CapaEntidad.Estudiante est;
            if (dgvEstudiantes.CurrentRow != null)
            {
                est = (CapaEntidad.Estudiante)dgvEstudiantes.CurrentRow.DataBoundItem;
                Matricula m = LgcMatricula.Instancia.BuscarMatricula(est.Id);
                var ed = new EstudianteDetalle(m);
                ed.Show();
            }
        }
        public void ListarEstudiantesInHabilitados()
        {
            dgvEstInhabilitado.DataSource = LgcEstudiante.Instancia.ListarEstudiantesInHabilitados();
        }

        private void btnEstHabilitar_Click(object sender, EventArgs e)
        {
            Estudiante est;
            if (dgvEstInhabilitado.CurrentRow != null)
            {
                est = (Estudiante)dgvEstInhabilitado.CurrentRow.DataBoundItem;
                Matricula matricula = LgcMatricula.Instancia.BuscarMatriculaI(est.Id);
                LgcMatricula.Instancia.CambiarEstadoMatricula(matricula);
                ListarEstudiantesInHabilitados();
            }
        }

        private void btnTutDetalles_Click(object sender, EventArgs e)
        {
            Tutor tu = null;
            if (dgvTutor.CurrentRow != null)
            {
                tu = (Tutor)dgvTutor.CurrentRow.DataBoundItem;
                var ed = new TutorDetalle(tu);
                ed.Show();
            }

        }

    }
}
