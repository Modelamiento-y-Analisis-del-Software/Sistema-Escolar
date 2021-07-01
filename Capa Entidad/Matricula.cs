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
        public Estudiante Estudnte { get; set; }
        public Grado GradoEsc { get; set; }
        public char Turno { get; set; }
        public string EscuelaProcedencia { get; set; }
        public DateTime FecInscripcion { get; set; }
        public bool Estado { get; set; }    
    }
}
