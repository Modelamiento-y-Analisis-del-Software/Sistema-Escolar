using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LgcTutor
    {
        public static LgcTutor Instancia { get; } = new LgcTutor();

        public List<Tutor> ListarTutores()
        {
            return SqlTutor.Instancia.ListarTutores();
        }
    }
}
