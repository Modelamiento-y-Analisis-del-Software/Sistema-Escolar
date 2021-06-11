using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class CreateEstudiante : UserControl
    {
        public event KeyPressEventHandler keypress;
        public frmMainWindow MainWindow { get; set; }
        public CreateEstudiante()
        {
            InitializeComponent();
            
        }

        protected void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress?.Invoke(this, e);
        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuGroupBox7_Enter(object sender, EventArgs e)
        {

        }
    }
}
