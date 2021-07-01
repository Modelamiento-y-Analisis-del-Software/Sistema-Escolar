using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Calificacion
    {
        public int Id { get; set; }
        public Tema EntTema { get; set; }
        public int Nota { get; set; }
    }
}
