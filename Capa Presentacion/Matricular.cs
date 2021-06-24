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

namespace CapaPresentacion
{
    public partial class Matricular : UserControl
    {
        public event KeyPressEventHandler keyp;
        public frmMainWindow MainWindow { get; set; }
        public Matricular()
        {
            InitializeComponent();
            InitialState();
        }

        private void InitialState()
        {
            rdbTutorNuevoSi.Select();
            grbTutorExistente.Enabled = false;
        }

        protected void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.keyp?.Invoke(this, e);


        }

        private void rdbTutorNuevoNo_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (rdbTutorNuevoNo.Checked)
            {
                grbNuevoTutor.Enabled = false;
                grbTutorExistente.Enabled = true;
            }

        }

        private void rdbTutorNuevoSi_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (rdbTutorNuevoSi.Checked)
            {
                grbNuevoTutor.Enabled = true;
                grbTutorExistente.Enabled = false;
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            DialogResult result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                imgEstPerfil.Image = Image.FromFile(f.FileName);
            }
        }

        private void RealizarMatricula()
        {
            Estudiante e = new Estudiante
            {
                Dni = txtEstDni.Text.ToString().Trim(),
                Nombres = txtEstNombre.Text.ToString().Trim(),
                ApPaterno = txtEstApPaterno.Text.ToString().Trim(),
                ApMaterno = txtEstApMaterno.Text.ToString().Trim(),
                Sexo = rdbEstMasculino.Checked ? 'M' : 'F',
                FecNacimiento = dpkEstFecNacimiento.Value,
                Direccion = txtEstDireccion.Text.ToString().Trim(),
            };

            if (rdbTutorNuevoSi.Checked)
            {
                Tutor t = new Tutor
                {
                    Dni = txtTutDni.Text.ToString().Trim(),
                    Nombres = txtTutNombres.Text.ToString().Trim(),
                    ApPaterno = txtTutApPaterno.Text.ToString().Trim(),
                    ApMaterno = txtTutApMaterno.Text.ToString().Trim(),
                    Sexo = rdbTutMasculino.Checked ? 'M' : 'F',
                    FecNacimiento = dpkTutFecNacimiento
                };

            }


        }
    }
}
