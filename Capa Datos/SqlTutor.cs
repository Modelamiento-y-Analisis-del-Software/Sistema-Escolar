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
    public class SqlTutor
    {
        public static SqlTutor Instancia { get; } = new SqlTutor();

        public List<Tutor> ListarTutores()
        {
            SqlCommand cmd = null;
            var lista = new List<Tutor>();
            try
            {
                var cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspListarTutores", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var e = new Tutor
                    {
                        Id = Convert.ToInt32(dr["IdTutor"]),
                        Dni = dr["Dni"].ToString(),
                        Nombres = dr["Nombres"].ToString(),
                        ApPaterno = dr["ApPaterno"].ToString(),
                        ApMaterno = dr["ApMaterno"].ToString(),
                        Sexo = dr["Sexo"].ToString().ElementAt(0),
                        FecNacimiento = Convert.ToDateTime(dr["FecNacimiento"]),
                        Direccion = dr["Direccion"].ToString(),
                        Email = dr["Email"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Ocupacion = dr["Ocupacion"].ToString(),
                        NvAcademico= dr["NvAcademico"].ToString()
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