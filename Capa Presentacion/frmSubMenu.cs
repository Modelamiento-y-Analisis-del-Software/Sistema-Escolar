using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace Capa_Presentacion
{
    public partial class frmSubMenu : UserControl
    {
        private frmMainWindow mainWindow;

        public frmSubMenu()
        {
            InitializeComponent();
            if (Program.IsInDesignMode()) return;
            hider.Height = 28;

            VSReactive<int>.Subscribe("menu", e => tabControl1.SelectedIndex = e);
        }

        public frmMainWindow MainWindow { get => mainWindow; set => mainWindow = value; }

        private void btnOption2_1_Click(object sender, EventArgs e)
        {
            mainWindow.PagCentral.SetPage("TutGeneral"); 
        }

        private void btnOption2_2_Click(object sender, EventArgs e)
        {
            mainWindow.PagCentral.SetPage("TutRegistrar"); 
        }
        private void BtnOption3_1_Click(object sender, EventArgs e)
        {
            mainWindow.PagCentral.SetPage("EstGeneral"); 
        }

        private void btnOption3_2_Click(object sender, EventArgs e)
        {
            mainWindow.PagCentral.SetPage("Matricular"); 
        }

        private void btnOption1_2_Click(object sender, EventArgs e)
        {
            mainWindow.PagCentral.SetPage("Matricular");

        }

        private void btnOpcion4_1_Click(object sender, EventArgs e)
        {
            mainWindow.PagCentral.SetPage("DocGeneral");
        }

        private void btnOpcion4_2_Click(object sender, EventArgs e)
        {
            mainWindow.PagCentral.SetPage("DocRegistrar");
        }
    }
}
