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
    public class SqlGrado
    {
        public static SqlGrado Instancia { get; } = new SqlGrado();

        public List<Grado> ListarAulas()
        {
            SqlCommand cmd = null;
            var lista = new List<Grado>();
            try
            {
                var cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspListarGrados", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var grado = new Grado();
                    grado.Id = Convert.ToInt32(dr["IdGrado"]);
                    grado.NGrado = Convert.ToInt32(dr["Grado"]);
 
                    lista.Add(grado);
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
