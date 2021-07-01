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
    public partial class Matricular : UserControl
    {

        public MiniBuscarTutor MBTutor { get; set; }
        public MiniBuscarEstudiante MBEstudiante { get; set; }
        public frmMainWindow MainWindow { get; set; }

        public Matricular()
        {
            InitializeComponent();
            InitialState();
            CleanScreen();
        }

        private void InitialState()
        {
            rdbTutorNuevoSi.Select();
            grbTutorExistente.Enabled = false;
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

        public void LoadMatricula(Matricula m)
        {
            Aula aula;
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

        private void RealizarMatricula()
        {
            Estudiante e;
            Matricula m;
            Aula aula = new Aula();
            bool exito = false;
            if (rdbNewMatrSi.Checked)
            {
                e = new Estudiante
                {
                    Dni = txtEstDni.Text.ToString().Trim(),
                    Nombres = txtEstNombre.Text.ToString().Trim(),
                    ApPaterno = txtEstApPaterno.Text.ToString().Trim(),
                    ApMaterno = txtEstApMaterno.Text.ToString().Trim(),
                    Sexo = rdbEstMasculino.Checked ? 'M' : 'F',
                    FecNacimiento = dpkEstFecNacimiento.Value,
                    Direccion = txtEstDireccion.Text.ToString().Trim(),
                    Email = txtEstEmail.Text.ToString().Trim(),
                    Telefono = txtEstTelefono.Text.ToString().Trim(),
                    Foto = imgEstPerfil.Image,
                };

                m = new Matricula();
                Grado grado = new Grado();
                grado.Id = 
                    rdbGrado1.Checked ? 1 :
                    rdbGrado2.Checked ? 2 :
                    rdbGrado3.Checked ? 3 :
                    rdbGrado4.Checked ? 4 :
                    rdbGrado5.Checked ? 5 : 0;
                m.Estudnte = e;
                aula.Seccion = cbbSeccion.Text.ElementAt(0);
                m.Turno =
                    rdbMañana.Checked ? 'M' :
                    rdbTarde.Checked ? 'T' :
                    rdbNoche.Checked ? 'N' : 'E';
                m.EscuelaProcedencia = txtEscuelaProc.Text.ToString().Trim();
                m.FecInscripcion = dpkFecInscripcion.Value;
                m.Estado = true;
                m.GradoEsc = grado;

                exito = LgcMatricula.Instancia.InsertarMatricula(m);
                e.Id = LgcEstudiante.Instancia.BuscarEstudiante(e.Dni).First().Id;
                Tutor t;
                string parentesco;

                if (rdbTutorNuevoSi.Checked)
                {
                    t = new Tutor
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
                    parentesco = CmbParentescoNew.Text.ToString().Trim();
                }
                else
                {
                    t = MBTutor.EntidadTutor;
                    parentesco = cmbTutParentescoExist.Text.ToString().Trim();
                }

                LgcTutor.Instancia.InsertarTutor(t, e, parentesco);

            }
            else if (rdbNewMatrNo.Checked)
            {
                e = MBEstudiante.Est;
                m = LgcMatricula.Instancia.BuscarMatricula(e.Id);

                m.GradoEsc.Id =
                    rdbGrado1.Checked ? 1 :
                    rdbGrado2.Checked ? 2 :
                    rdbGrado3.Checked ? 3 :
                    rdbGrado4.Checked ? 4 :
                    rdbGrado5.Checked ? 5 : 0;
                aula.Seccion = cbbSeccion.Text.ElementAt(0);
                m.Turno =
                    rdbMañana.Checked ? 'M' :
                    rdbTarde.Checked ? 'T' :
                    rdbNoche.Checked ? 'N' : 'E';
                m.EscuelaProcedencia = txtEscuelaProc.Text.ToString().Trim();
                m.FecInscripcion = dpkFecInscripcion.Value;
                exito = LgcMatricula.Instancia.ActualizarMatricula(m);
            }
            if (exito)
                MessageBox.Show("Exito al guardar");
            else
                MessageBox.Show("Fallo al guardar");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            RealizarMatricula();
            CleanScreen();
        }

        private void btnTutSearch_Click(object sender, EventArgs e)
        {
            MBTutor = new MiniBuscarTutor(this);
            MBTutor.Show();
        }

        public void CleanScreen()
        {
            txtEstDni.Text = "";
            txtEstNombre.Text = "";
            txtEstApPaterno.Text = "";
            txtEstApMaterno.Text = "";
            rdbEstMasculino.Checked = true;
            rdbEstFemenino.Checked = false;
            txtEstDireccion.Text = "";
            txtEstEmail.Text = "";
            txtEstTelefono.Text = "";

            rdbGrado1.Checked = true;
            rdbGrado2.Checked = false;
            rdbGrado3.Checked = false;
            rdbGrado4.Checked = false;
            rdbGrado5.Checked = false;
            cbbSeccion.SelectedIndex = 0;
            rdbMañana.Checked = true;
            rdbTarde.Checked = false;
            rdbNoche.Checked = false;

            txtEscuelaProc.Text = "";

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
        }

        private void btnEstSearch_Click(object sender, EventArgs e)
        {
            MBEstudiante = new MiniBuscarEstudiante(this);
            MBEstudiante.Show();
        }

        private void rdbNewMatrSi_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (rdbNewMatrSi.Checked)
            {
                grpbDatosDelEstudiante.Enabled = true;
                grbMatriculaExistente.Enabled = false;
                grbNuevoTutor.Enabled = true;
                grbRdbNuevoT.Enabled = true;
            }
        }

        private void rdbNewMatrNo_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (rdbNewMatrNo.Checked)
            {
                grpbDatosDelEstudiante.Enabled = false;
                grbMatriculaExistente.Enabled = true;
                grbNuevoTutor.Enabled = false;
                grbRdbNuevoT.Enabled = false;
            }
        }
    }
}