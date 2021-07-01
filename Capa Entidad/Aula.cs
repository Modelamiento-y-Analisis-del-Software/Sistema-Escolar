using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Aula
    {
        public int Id { get; set; }
        public Grado EntGrado { get; set; }
        public char Seccion { get; set; }
        public int Capacidad { get; set; }
        public bool Estado { get; set; }
    }
}
