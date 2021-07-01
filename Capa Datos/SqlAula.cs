using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class SqlAula
    {
        public static SqlAula Instancia { get; } = new SqlAula();

        public List<Aula> ListarAulas()
        {
            SqlCommand cmd = null;
            var lista = new List<Aula>();
            try
            {
                var cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspListarAulas", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var grado = new Grado();
                    var aula = new Aula();
                    aula.Id = Convert.ToInt32(dr["IdAula"]);
                    grado.Id = Convert.ToInt32(dr["IdGrado"]);
                    aula.Seccion = dr["Seccion"].ToString().ElementAt(0);
                    aula.Capacidad = Convert.ToInt32(dr["Capacidad"]);
                    aula.Estado = Convert.ToBoolean(dr["Estado"]);

                    aula.EntGrado = grado;

                    lista.Add(aula);
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
