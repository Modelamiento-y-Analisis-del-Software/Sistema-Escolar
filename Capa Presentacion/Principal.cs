using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using KimtToo.VisualReactive;

namespace Capa_Presentacion
{
    public partial class frmMainWindow : Form
    {
        
        public frmMainWindow()
        {
            InitializeComponent();
            ListarEstudiantesHabilitados();
            frmSubMenu1.MainWindow = this;
            uscNewEstudent.MainWindow = this;
            uscNewEstudent.keypress += new KeyPressEventHandler(TxtEstDni_KeyPress);
        }

        public void TxtEstDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        bool mnuExpanded = false;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!menuTransition.IsCompleted) return;
            if (pnlMainMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!mnuExpanded)
                {
                    mnuExpanded = true;
                    pnlMainMenu.Width = 250;
                }
            }
            else
            {
                if (mnuExpanded)
                {
                    mnuExpanded = false;
                    pnlMainMenu.Width = 55;
                    menuTransition.Show(pnlMainMenu);
                }
            }

        }

        private void ListarEstudiantesHabilitados()
        {
            dgvEstudiantes.DataSource = LgcEstudiante.Instancia.ListarEstudiantesHabilitados();
        }

        private void SideMenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
        }
        
        private void BtnTutor_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            PagCentral.SetPage("TutGeneral"); 
        }
        private void BtnEstudiante_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            PagCentral.SetPage("EstGeneral"); 
        }
    }
}
