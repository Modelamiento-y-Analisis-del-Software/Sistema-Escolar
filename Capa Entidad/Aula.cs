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
        public int Grado { get; set; }
        public int Seccion { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}
