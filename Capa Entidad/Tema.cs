using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Tema
    {
        public int Id { get; set; }
        public Curso EntCurso { get; set; }
        public Calificacion EntCalificacion { get; set; }
    }
}
