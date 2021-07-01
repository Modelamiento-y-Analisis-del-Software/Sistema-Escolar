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
namespace CapaPresentacion.Detalles
{
    public partial class DocenteDetalle : Form
    {
        Docente d;
        public DocenteDetalle()
        {
            InitializeComponent();
            CleanScreen();
            this.d = d;
            LoadData();
        }
        public void CleanScreen()
        {
            txtDocNombre.Text = "";
            txtDocDni.Text = "";
            txtDocApPaterno.Text = "";
            txtDocApMaterno.Text = "";
            txtDocTelefono.Text = "";
            txtDocEmail.Text = "";
            txtDocDireccion.Text = "";
            txtDocEsp.Text = "";
            rdbDocMasculino.Checked = true;
            rdbDocFemenino.Checked = false;
        }
        public void LoadData()
        {
            //imgDocPerfil.Image = d.Foto;
            txtDocNombre.Text = d.Nombres.ToString();
            txtDocDni.Text = d.Dni;
            txtDocApPaterno.Text = d.ApPaterno;
            txtDocApMaterno.Text = d.ApMaterno;
            txtDocTelefono.Text = d.Telefono.Trim();
            txtDocEmail.Text = d.Email;
            txtDocDireccion.Text = d.Direccion;
            dpkDocFecNacimiento.Value = d.FecNacimiento;

            if (d.Sexo == 'M')
            {
                rdbDocMasculino.Checked = true;
                rdbDocFemenino.Checked = false;
            }
            else
            {
                rdbDocMasculino.Checked = false;
                rdbDocFemenino.Checked = true;
            }


        }
        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void btnImageDoc_Click(object sender, EventArgs e)
        {
            //    OpenFileDialog f = new OpenFileDialog();
            //    DialogResult result = f.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        imgDocPerfil.Image = Image.FromFile(f.FileName);
            //    }

        }

        private void btnEditarDoc_Click(object sender, EventArgs e)
        {
            btnEditarDoc.Enabled = false;
            btnConfirmarDoc.Enabled = true;
            btnImageDoc.Enabled = true;
            txtDocTelefono.ReadOnly = false;
            txtDocEmail.ReadOnly = false;
            txtDocDireccion.ReadOnly = false;
            txtDocEsp.ReadOnly = false;
        }

        private void btnConfirmarDoc_Click(object sender, EventArgs e)
        {
            d.Telefono = txtDocTelefono.Text.Trim();
            d.Email = txtDocEmail.Text.Trim();
            d.Direccion = txtDocDireccion.Text.Trim();
            //d.Especialidad = txtDocEsp.Text.Trim();
            //d.Foto = imgDocPerfil.Image;
            //LgcEstudiante.Instancia.ActualizarEstudiante(m.Estudnte);
            txtDocTelefono.ReadOnly = true;
            txtDocEmail.ReadOnly = true;
            txtDocDireccion.ReadOnly = true;
            btnConfirmarDoc.Enabled = false;
            btnEditarDoc.Enabled = true;
            btnImageDoc.Enabled = true;
        }
    }
}
