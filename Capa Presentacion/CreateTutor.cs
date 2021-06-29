using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class CreateTutor : UserControl
    {
        MiniBuscarEstudiante buscarE;

        public CreateTutor()
        {
            InitializeComponent();
        }

        private void btnTutSearch_Click(object sender, EventArgs e)
        {
            buscarE = new MiniBuscarEstudiante(this);
            buscarE.Show();
        }

        public void CleanScreen()
        {
            txtTutDni.Text = "";
            txtTutNombres.Text = "";
            txtTutApPaterno.Text = "";
            txtTutApMaterno.Text = "";
            rdbTutMasculino.Checked = true;
            rdbTutFemenino.Checked = false;
            txtTutDireccion.Text = "";
            txtTutEmail.Text = "";
            txtTutTelefono.Text = "";
            txtTutOcupacion.Text = "";
            cmbTutGrado.SelectedIndex = 0;
            CmbParentescoNew.SelectedIndex = 0;
            txtEstSearch.Text = "";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string parentesco;
            var t = new Tutor
            {
                Dni = txtTutDni.Text.ToString().Trim(),
                Nombres = txtTutNombres.Text.ToString().Trim(),
                ApPaterno = txtTutApPaterno.Text.ToString().Trim(),
                ApMaterno = txtTutApMaterno.Text.ToString().Trim(),
                Sexo = rdbTutMasculino.Checked ? 'M' : 'F',
                FecNacimiento = dpkTutFecNacimiento.Value,
                Direccion = txtTutDireccion.Text.ToString().Trim(),
                Email = txtTutEmail.Text.ToString().Trim(),
                Telefono = txtTutTelefono.Text.ToString().Trim(),
                Ocupacion = txtTutOcupacion.Text.ToString().Trim(),
                NvAcademico = cmbTutGrado.Text.ToString().Trim()
            };
            Estudiante est = buscarE.Est;
            parentesco = CmbParentescoNew.Text.ToString().Trim();
            LgcTutor.Instancia.InsertarTutor(t, est, parentesco);
        }
    }
}
