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
    public partial class CreateDocente : UserControl
    {
        public CreateDocente()
        {
            InitializeComponent();
        }

        public void CleanScreen ()
        {
            txtDocDni.Text = "";
            txtDocNombres.Text = "";
            txtDocApPaterno.Text = "";
            txtDocApMaterno.Text = "";
            rdbDocMasculino.Checked = false;
            rdbDocFemenino.Checked = false;
            txtDocDireccion.Text = "";
            txtDocEmail.Text = "";
            txtDocTelefono.Text = "";
            txtDocEspecialidad.Text = "";
        }

        private void btnConfirmarRDoc_Click(object sender, EventArgs e)
        {
            var D = new Docente
            {
                Dni = txtDocDni.Text.ToString().Trim(),
                Nombre = txtDocNombres.Text.ToString().Trim(),
                ApPaterno = txtDocApPaterno.Text.ToString().Trim(),
                ApMaterno = txtDocApMaterno.Text.ToString().Trim(),
                Sexo = rdbDocMasculino.Checked ? 'M' : 'F',
                FecNacimiento = dpkDocFecNacimiento.Value,
                Direccion = txtDocDireccion.Text.ToString().Trim(),
                Email = txtDocEmail.Text.ToString().Trim(),
                Telefono = txtDocTelefono.Text.ToString().Trim(),
                Especialidad = txtDocEspecialidad.Text.ToString().Trim()
            };
            LgcDocente.Instancia.InsertarDocente(D);
        }
    }
}
