using CapaEntidad;
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
    public partial class TutorDetalle : Form
    {
        Tutor t ;
        public TutorDetalle()
        {
            InitializeComponent();
            CleanScreen();
                //aea
        }
        public TutorDetalle(Tutor t )
        {
            InitializeComponent();
            CleanScreen();
            this.t = t;
            LoadData();
            //aea
        }
        public void CleanScreen()
        {
            txtTutNombres.Text = "";
            txtTutDni.Text = "";
            txtTutApPaterno.Text = "";
            txtTutApMaterno.Text = "";
            txtTutTelefono.Text = "";
            txtTutEmail.Text = "";
            txtTutDireccion.Text = "";
            txtTutOcupacion.Text = "";

            rdbTutMasculino.Checked = true;
            rdbTutFemenino.Checked = false;

            cbbNivelAcademico.SelectedIndex = 0;
        }

        public void LoadData()
        {
            txtTutNombres.Text = t.Nombres.ToString();
            txtTutDni.Text = t.Dni;
            txtTutApPaterno.Text = t.ApPaterno;
            txtTutApMaterno.Text = t.ApMaterno;
            txtTutTelefono.Text = t.Telefono;
            txtTutEmail.Text = t.Email;
            txtTutDireccion.Text = t.Direccion;
            txtTutOcupacion.Text = t.Ocupacion;
            dpkTutFecNacimiento.Value = t.FecNacimiento;

            if (t.Sexo == 'M')
            {
                rdbTutMasculino.Checked = true;
                rdbTutFemenino.Checked = false;
            }
            else
            {
                rdbTutMasculino.Checked = false;
                rdbTutFemenino.Checked = true;
            }

            cbbNivelAcademico.SelectedItem = t.NvAcademico;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnConfirmar.Enabled = true;
            txtTutTelefono.Enabled = true;
            txtTutEmail.Enabled = true;
            txtTutDireccion.Enabled = true;
            txtTutOcupacion.Enabled = true;
            cbbNivelAcademico.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnConfirmar.Enabled = false;
            txtTutTelefono.Enabled = false;
            txtTutEmail.Enabled = false;
            txtTutDireccion.Enabled = false;
            txtTutOcupacion.Enabled = false;
            cbbNivelAcademico.Enabled = false;

            t.Telefono = txtTutTelefono.Text.ToString().Trim();
            t.Email = txtTutEmail.Text.ToString().Trim();
            t.Direccion = txtTutDireccion.Text.ToString().Trim();
            t.Ocupacion = txtTutOcupacion.Text.ToString().Trim();
            t.NvAcademico = cbbNivelAcademico.Text.ToString().Trim();
        }
    }
}
