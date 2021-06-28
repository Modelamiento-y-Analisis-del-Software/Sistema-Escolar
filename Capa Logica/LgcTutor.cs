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

        public List<Tutor> SearchTutor(string dni)
        {
            var lista = SqlTutor.Instancia.ListarTutores();
            List<Tutor> encontrados = new List<Tutor>();
            foreach(var e in lista)
            {
                if (e.Dni.StartsWith(dni))
                    encontrados.Add(e);
            }
            return encontrados;
        }
        
        public bool InsertarTutor(Tutor t, Estudiante e, string parentesco)
        {
            return SqlTutor.Instancia.InsertarTutor(t, e, parentesco);
        }
    }
}
