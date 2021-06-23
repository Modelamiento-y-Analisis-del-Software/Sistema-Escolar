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
    public class SqlEstudiante
    {
        public static SqlEstudiante Instancia { get; } = new SqlEstudiante();

        public List<Estudiante> ListarEstudiantes()
        {
            SqlCommand cmd = null;
            var lista = new List<Estudiante>();
            try
            {
                var cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarEstudiantes", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var e = new Estudiante
                    {
                        IdEstudiante = Convert.ToInt32(dr["IdEstudiante"]),
                        Dni = dr["Dni"].ToString(),
                        Nombres = dr["Nombres"].ToString(),
                        ApPaterno = dr["ApPaterno"].ToString(),
                        ApMaterno = dr["ApMaterno"].ToString(),
                        Sexo = dr["Sexo"].ToString().ElementAt(0),
                        FecNacimiento = Convert.ToDateTime(dr["FecNacimiento"]),
                        Direccion = dr["Direccion"].ToString(),
                        Email = dr["Email"].ToString(),
                    };
                    lista.Add(e);
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
