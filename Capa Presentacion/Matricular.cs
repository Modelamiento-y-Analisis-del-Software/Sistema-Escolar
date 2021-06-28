﻿using System;
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
        public event KeyPressEventHandler keyp;

        public MiniBuscarTutor MBTutor { get; set; }
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
                Email = txtEstEmail.Text.ToString().Trim(),
                Telefono = txtEstTelefono.Text.ToString().Trim(),
                Foto = imgEstPerfil.Image,
            };

            Matricula m = new Matricula
            {
                Estudnte = e,
                GradoEscolar =
                    rdbGrado1.Checked ? 1 :
                    rdbGrado2.Checked ? 2 :
                    rdbGrado3.Checked ? 3 :
                    rdbGrado4.Checked ? 4 :
                    rdbGrado5.Checked ? 5 : 0,
                Seccion = cbbSeccion.Text.ElementAt(0),
                Turno =
                    rdbMañana.Checked ? 'M' :
                    rdbTarde.Checked ? 'T' :
                    rdbNoche.Checked ? 'N' : 'E',
                EscuelaProcedencia = txtEscuelaProc.Text.ToString().Trim(),
                FecInscripcion = dpkFecInscripcion.Value,
                Estado = true
            };

            LgcMatricula.Instancia.InsertarMatricula(m);
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
            MessageBox.Show("Exito al guardar");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            RealizarMatricula();
            CleanScreen();
        }

        private void btnTutSearch_Click(object sender, EventArgs e)
        {
            MBTutor =  new MiniBuscarTutor(this);
            MBTutor.Show();
        }

        public void CleanScreen()
        {
            txtEstDni.Text = "";
            txtEstNombre.Text = "";
            txtEstApPaterno.Text = "";
            txtEstApMaterno.Text = "";
            rdbEstMasculino.Checked = true;
            txtEstDireccion.Text = "";
            txtEstEmail.Text = "";
            txtEstTelefono.Text = "";

            rdbGrado1.Checked = true;
            cbbSeccion.SelectedIndex = 0;
            rdbMañana.Checked = true;
            txtEscuelaProc.Text = "";

            txtTutDni.Text = "";
            txtTutNombres.Text = "";
            txtTutApPaterno.Text = "";
            txtTutApMaterno.Text = "";
            rdbTutMasculino.Checked = true;
            txtTutDireccion.Text = "";
            txtTutEmail.Text = "";
            txtTutTelefono.Text = "";
            txtTutOcupacion.Text = "";
            cmbTutGrado.SelectedIndex = 0;
            CmbParentescoNew.SelectedIndex = 0;
        }
    }
}