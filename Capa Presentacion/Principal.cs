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
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
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

        private void SideMenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
        }
    }
}
