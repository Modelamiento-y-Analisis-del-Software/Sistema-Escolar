using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LgcAula
    {
        public static LgcAula Instancia { get; } = new LgcAula();

        public List<Aula> ListarAulas()
        {
            return SqlAula.Instancia.ListarAulas();
        }
    }
}
