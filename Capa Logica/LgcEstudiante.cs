using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LgcEstudiante
    {
        public static LgcEstudiante Instancia { get; } = new LgcEstudiante();

        public List<Estudiante> ListarEstudiantesHabilitados() 
        {
            return SqlEstudiante.Instancia.ListarEstudiantesHabilitados();
        }

        public List<Estudiante> ListarEstudiantesInHabilitados() 
        {
            return SqlEstudiante.Instancia.ListarEstudiantesInHabilitados();
        }

        public List<Estudiante> BuscarEstudiante(string dni)
        {
            return SqlEstudiante.Instancia.BuscarEstudiante(dni);
        }

        public bool ActualizarEstudiante(Estudiante e)
        {
            return SqlEstudiante.Instancia.ActualizarEstudiante(e);
        }
        public Dictionary<string, Estudiante> ListarEstudiantesDeTutor(Tutor t)
        {
            return SqlEstudiante.Instancia.ListarEstudiantesDeTutor(t);
        }
        public Dictionary<string, string> ParentescoEst(Tutor t)
        {
            var dict = SqlEstudiante.Instancia.ListarEstudiantesDeTutor(t);
            Dictionary<string, string> parentescos = new Dictionary<string, string>();
            string fullname;
            foreach (var e in dict)
            {
                fullname = e.Value.Nombres + " " + e.Value.ApPaterno + " " + e.Value.ApMaterno;
                parentescos.Add(e.Key, fullname);
            }
            return parentescos;
        }
    }
}
