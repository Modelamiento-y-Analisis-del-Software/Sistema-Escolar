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
    public partial class CreateCurso : UserControl
    {
        public CreateCurso()
        {
            InitializeComponent();
        }

        private void btnConfirmarCurso_Click(object sender, EventArgs e)
        {
            //private void RealizarCurso()
            //{
            //    Estudiante e;
                
            //        m = new Matricula();
            //        m.Estudnte = e;
            //        m.GradoEscolar =
            //            rdbGrado1.Checked ? 1 :
            //            rdbGrado2.Checked ? 2 :
            //            rdbGrado3.Checked ? 3 :
            //            rdbGrado4.Checked ? 4 :
            //            rdbGrado5.Checked ? 5 : 0;
            //        m.EntAula.Seccion = cbbSeccion.Text.ElementAt(0);
            //        m.Turno =
            //            rdbMañana.Checked ? 'M' :
            //            rdbTarde.Checked ? 'T' :
            //            rdbNoche.Checked ? 'N' : 'E';
            //        m.EscuelaProcedencia = txtEscuelaProc.Text.ToString().Trim();
            //        m.FecInscripcion = dpkFecInscripcion.Value;
            //        m.Estado = true;

            //        exito = LgcMatricula.Instancia.InsertarMatricula(m);
            //        e.Id = LgcEstudiante.Instancia.BuscarEstudiante(e.Dni).First().Id;
            //        Tutor t;
            //        string parentesco;

            //        if (rdbTutorNuevoSi.Checked)
            //        {
            //            t = new Tutor
            //            {
            //                Dni = txtTutDni.Text.ToString().Trim(),
            //                Nombres = txtTutNombres.Text.ToString().Trim(),
            //                ApPaterno = txtTutApPaterno.Text.ToString().Trim(),
            //                ApMaterno = txtTutApMaterno.Text.ToString().Trim(),
            //                Sexo = rdbTutMasculino.Checked ? 'M' : 'F',
            //                FecNacimiento = dpkTutFecNacimiento.Value,
            //                Direccion = txtTutDireccion.Text.ToString().Trim(),
            //                Email = txtTutEmail.Text.ToString().Trim(),
            //                Telefono = txtTutTelefono.Text.ToString().Trim(),
            //                Ocupacion = txtTutOcupacion.Text.ToString().Trim(),
            //                NvAcademico = cmbTutGrado.Text.ToString().Trim()
            //            };
            //            parentesco = CmbParentescoNew.Text.ToString().Trim();
            //        }
            //        else
            //        {
            //            t = MBTutor.EntidadTutor;
            //            parentesco = cmbTutParentescoExist.Text.ToString().Trim();
            //        }

            //        LgcTutor.Instancia.InsertarTutor(t, e, parentesco);

            //    }
            //    else if (rdbNewMatrNo.Checked)
            //    {
            //        e = MBEstudiante.Est;
            //        m = LgcMatricula.Instancia.BuscarMatricula(e.Id);
            //        m.GradoEscolar =
            //            rdbGrado1.Checked ? 1 :
            //            rdbGrado2.Checked ? 2 :
            //            rdbGrado3.Checked ? 3 :
            //            rdbGrado4.Checked ? 4 :
            //            rdbGrado5.Checked ? 5 : 0;
            //        m.EntAula.Seccion = cbbSeccion.Text.ElementAt(0);
            //        m.Turno =
            //            rdbMañana.Checked ? 'M' :
            //            rdbTarde.Checked ? 'T' :
            //            rdbNoche.Checked ? 'N' : 'E';
            //        m.EscuelaProcedencia = txtEscuelaProc.Text.ToString().Trim();
            //        m.FecInscripcion = dpkFecInscripcion.Value;
            //        exito = LgcMatricula.Instancia.ActualizarMatricula(m);
            //    }
            //    if (exito)
            //        MessageBox.Show("Exito al guardar");
            //    else
            //        MessageBox.Show("Fallo al guardar");
            //}
        }
    }
}
