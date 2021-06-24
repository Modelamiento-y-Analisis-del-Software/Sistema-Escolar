using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Matricula
    {
        public int Id { get; set; }
        public Estudiante Estudiante { get; set; }
        public int GradoEscolar { get; set; }
        public char Seccion { get; set; }
        public char Turno { get; set; }
        public string EscuelaProcedencia { get; set; }
        public DateTime FecInscripcion { get; set; }
        public bool Estado { get; set; }    
    }
}
