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

        public frmSubMenu()
        {
            InitializeComponent();
            if (Program.IsInDesignMode()) return;
            hider.Height = 30;

            VSReactive<int>.Subscribe("menu", e => tabControl1.SelectedIndex = e);
        }
    }
}
