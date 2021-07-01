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
    public partial class EstudianteDetalles : UserControl
    {
        public EstudianteDetalles()
        {
            InitializeComponent();
            CleanScreen();
        }

        public void CleanScreen()
        {
            txtEstNombre.Text = "";
            txtEstDni.Text = "";
            txtEstApPaterno.Text = "";
            txtEstApMaterno.Text = "";
            txtEstTelefono.Text = "";
            txtEstEmail.Text = "";
            txtEstDireccion.Text = "";

            rdbEstMasculino.Checked = true;
            rdbEstFemenino.Checked = false;

            rdbGrado1.Checked = true;
            rdbGrado2.Checked = false;
            rdbGrado3.Checked = false;
            rdbGrado4.Checked = false;
            rdbGrado5.Checked = false;

            rdbMañana.Checked = true;
            rdbTarde.Checked = false;
            rdbNoche.Checked = false;

            cbbSeccion.SelectedIndex = 0;
            txtEscuelaProc.Text = "";
        }

        public void LoadData(Matricula m)
        {
            imgEstPerfil.Image = m.Estudnte.Foto;
            txtEstNombre.Text = m.Estudnte.Nombres.ToString();
            txtEstDni.Text = m.Estudnte.Dni;
            txtEstApPaterno.Text = m.Estudnte.ApPaterno;
            txtEstApMaterno.Text = m.Estudnte.ApMaterno;
            txtEstTelefono.Text = m.Estudnte.Telefono;
            txtEstEmail.Text = m.Estudnte.Email;
            txtEstDireccion.Text = m.Estudnte.Direccion;
            dpkEstFecNacimiento.Value = m.Estudnte.FecNacimiento;

            if (m.Estudnte.Sexo == 'M')
            {
                rdbEstMasculino.Checked = true;
                rdbEstFemenino.Checked = false;
            }
            else
            {
                rdbEstMasculino.Checked = false;
                rdbEstFemenino.Checked = true;
            }

            if (m.GradoEsc.Id == 1)
            {
                rdbGrado1.Checked = true;
                rdbGrado2.Checked = false;
                rdbGrado3.Checked = false;
                rdbGrado4.Checked = false;
                rdbGrado5.Checked = false;
            }
            else if (m.GradoEsc.Id == 2)
            {
                rdbGrado1.Checked = false;
                rdbGrado2.Checked = true;
                rdbGrado3.Checked = false;
                rdbGrado4.Checked = false;
                rdbGrado5.Checked = false;
            }
            else if (m.GradoEsc.Id == 3)
            {
                rdbGrado1.Checked = false;
                rdbGrado2.Checked = false;
                rdbGrado3.Checked = true;
                rdbGrado4.Checked = false;
                rdbGrado5.Checked = false;
            }
            else if (m.GradoEsc.Id == 4)
            {
                rdbGrado1.Checked = false;
                rdbGrado2.Checked = false;
                rdbGrado3.Checked = false;
                rdbGrado4.Checked = true;
                rdbGrado5.Checked = false;
            }
            else if (m.GradoEsc.Id == 5)
            {
                rdbGrado1.Checked = false;
                rdbGrado2.Checked = false;
                rdbGrado3.Checked = false;
                rdbGrado4.Checked = false;
                rdbGrado5.Checked = true;
            }

            //cbbSeccion.SelectedItem = m.EntAula.Seccion;

            if (m.Turno == 'M')
            {
                rdbMañana.Checked = true;
                rdbTarde.Checked = false;
                rdbNoche.Checked = false;
            }
            else if (m.Turno == 'T')
            {
                rdbMañana.Checked = false;
                rdbTarde.Checked = true;
                rdbNoche.Checked = false;

            }
            else if (m.Turno == 'N')
            {
                rdbMañana.Checked = false;
                rdbTarde.Checked = false;
                rdbNoche.Checked = true;
            }

            txtEscuelaProc.Text = m.EscuelaProcedencia;
            dpkFecInscripcion.Value = m.FecInscripcion;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnConfirmar.Enabled = false;
        }
    }
}
