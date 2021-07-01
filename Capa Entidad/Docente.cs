using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Docente
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public char Sexo { get; set; }
        public DateTime FecNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int Especialidad { get; set; }
        public Image Foto { get; set; }
    }
}
