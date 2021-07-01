using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class LgcDocente
    {
        public static LgcDocente Instancia { get; } = new LgcDocente();

        public List<Docente> ListarDocente()
        {
            return SqlDocente.Instancia.ListarDocentes();
        }
        
        public bool InsertarDocente(Docente D)
        {
            return SqlDocente.Instancia.InsertarDocentes(D);
        }

        public List<Docente> BuscarDocente (string dni)
        {
            return SqlDocente.Instancia.BuscarDocentes(dni);
        }
    }
}
