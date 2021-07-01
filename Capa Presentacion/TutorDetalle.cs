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
        Tutor e ;
        public TutorDetalle()
        {
            InitializeComponent();
            CleanScreen();
                //aea
        }
        public TutorDetalle(Tutor e )
        {
            InitializeComponent();
            CleanScreen();
            this.e = e;
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
            txtTutNombres.Text = e.Nombres.ToString();
            txtTutDni.Text = e.Dni;
            txtTutApPaterno.Text = e.ApPaterno;
            txtTutApMaterno.Text = e.ApMaterno;
            txtTutTelefono.Text = e.Telefono;
            txtTutEmail.Text = e.Email;
            txtTutDireccion.Text = e.Direccion;
            txtTutOcupacion.Text = e.Ocupacion;
            dpkTutFecNacimiento.Value = e.FecNacimiento;

            if (e.Sexo == 'M')
            {
                rdbTutMasculino.Checked = true;
                rdbTutFemenino.Checked = false;
            }
            else
            {
                rdbTutMasculino.Checked = false;
                rdbTutFemenino.Checked = true;
            }

            cbbNivelAcademico.SelectedItem = e.NvAcademico;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnConfirmar.Enabled = false;
        }
    }
}
