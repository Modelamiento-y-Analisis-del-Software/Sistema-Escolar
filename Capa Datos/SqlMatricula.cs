using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class SqlMatricula
    {
        public static SqlMatricula Instancia { get; } = new SqlMatricula();

        public List<Matricula> ListarMatriculas()
        {
            SqlCommand cmd = null;
            var lista = new List<Matricula>();
            try
            {
                var cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspListarMatriculas", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var e = new Estudiante
                    {
                        Id = Convert.ToInt32(dr["IdEstudiante"])
                    };

                    var m = new Matricula
                    {
                        Id = Convert.ToInt32(dr["IdMatricula"]),
                        GradoEscolar = Convert.ToInt32(dr["Dni"]),
                        Seccion = dr["Seccion"].ToString().ElementAt(0),
                        Turno = dr["Turno"].ToString().ElementAt(0),
                        EscuelaProcedencia = dr["EscuelaProcedencia"].ToString(),
                        Estado = Convert.ToBoolean(dr["Nombres"]),
                    };

                    m.Estudiante = e;

                    lista.Add(m);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd?.Connection.Close(); }
            return lista;
        }

    }
}
