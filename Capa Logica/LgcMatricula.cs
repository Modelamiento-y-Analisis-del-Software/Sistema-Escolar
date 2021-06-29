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

        public List<Matricula> ListarMatriculasHabilitadas()
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

        public List<Matricula> ListarMatriculasInhabilitadas()
        {
            List<Estudiante> listaE = SqlEstudiante.Instancia.ListarEstudiantesInHabilitados();

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

        public Matricula BuscarMatricula(int idEstudiante)
        {
            Matricula encontrado = null;
            foreach (var m in ListarMatriculasHabilitadas())
            {
                if (m.Estudnte.Id == idEstudiante)
                {
                    encontrado = m;
                    break;
                }
            }
            return encontrado;
        }

        public Matricula BuscarMatriculaI(int idEstudiante)
        {
            Matricula encontrado = null;
            foreach (var m in ListarMatriculasInhabilitadas())
            {
                if (m.Estudnte.Id == idEstudiante)
                {
                    encontrado = m;
                    break;
                }
            }
            return encontrado;
        }

        public bool InsertarMatricula(Matricula m)
        {
            return SqlMatricula.Instancia.InsertarMatricula(m);
        }

        public bool CambiarEstadoMatricula(Matricula m)
        {
            return SqlMatricula.Instancia.CambiarEstadoMatricula(m);
        }

        public bool ActualizarMatricula(Matricula m)
        {
            return SqlMatricula.Instancia.ActualizarMatricula(m);
        }
    }
}
