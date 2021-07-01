using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Docente EntDocente { get; set; }
        public List<Grado> gra { get; set; }
    }
}
