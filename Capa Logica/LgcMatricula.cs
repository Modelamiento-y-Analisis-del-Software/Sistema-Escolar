using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class LgcMatricula
    {
        public static LgcMatricula Instancia { get; } = new LgcMatricula();

        public List<Matricula> ListarMatriculas()
        {

            List<Estudiante> listaE = SqlEstudiante.Instancia.ListarEstudiantesHabilitados();

            List<Matricula> listaM = SqlMatricula.Instancia.ListarMatriculas();

            foreach (Matricula m in listaM)
            {
                foreach (Estudiante e in listaE)
                {
                    if (m.Estudnte.Id == e.Id)
                    {
                        m.Estudnte = e;
                        break;
                    }
                }
            }
            return listaM;
        }

        public bool InsertarMatricula(Matricula m)
        {
            return SqlMatricula.Instancia.InsertarMatricula(m);
        }
    }
}
