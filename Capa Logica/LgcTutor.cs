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

        public Dictionary<string, Tutor> ListarTutoresEstudiantes(Estudiante est)
        {
            return SqlTutor.Instancia.ListarTutoresEstudiante(est);
        }

        public Dictionary<string, string> ParentescoTutor(Estudiante est)
        {
            var dict = SqlTutor.Instancia.ListarTutoresEstudiante(est);
            Dictionary<string, string> parentescos = new Dictionary<string, string>();
            string fullname;
            foreach(var e in dict)
            {
                fullname = e.Value.Nombres + " " + e.Value.ApPaterno + " " + e.Value.ApMaterno; 
                parentescos.Add(e.Key, fullname);
            }
            return parentescos;
        }
    }
}
