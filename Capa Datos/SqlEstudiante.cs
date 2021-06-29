using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Drawing;
using System.IO;

namespace CapaDatos
{
    public class SqlEstudiante
    {
        public static SqlEstudiante Instancia { get; } = new SqlEstudiante();

        public List<Estudiante> ListarEstudiantesHabilitados()
        {
            SqlCommand cmd = null;
            var lista = new List<Estudiante>();
            try
            {
                var cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspListarEstudiantesHabilitados", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var ms = new MemoryStream((byte[])dr["Foto"]);
                    var e = new Estudiante
                    {
                    Id = Convert.ToInt32(dr["IdEstudiante"]),
                        Dni = dr["Dni"].ToString(),
                        Nombres = dr["Nombres"].ToString(),
                        ApPaterno = dr["ApPaterno"].ToString(),
                        ApMaterno = dr["ApMaterno"].ToString(),
                        Sexo = dr["Sexo"].ToString().ElementAt(0),
                        FecNacimiento = Convert.ToDateTime(dr["FecNacimiento"]),
                        Direccion = dr["Direccion"].ToString(),
                        Email = dr["Email"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Foto = Image.FromStream(ms)
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

        public List<Estudiante> BuscarEstudiante(string dni)
        {
            SqlCommand cmd = null;
            var lista = new List<Estudiante>();
            try
            {
                var cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspSearchEstudiante", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Dni", dni);
                    
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var ms = new MemoryStream((byte[])dr["Foto"]);
                    var e = new Estudiante
                    {
                        Id = Convert.ToInt32(dr["IdEstudiante"]),
                        Dni = dr["Dni"].ToString(),
                        Nombres = dr["Nombres"].ToString(),
                        ApPaterno = dr["ApPaterno"].ToString(),
                        ApMaterno = dr["ApMaterno"].ToString(),
                        Sexo = dr["Sexo"].ToString().ElementAt(0),
                        FecNacimiento = Convert.ToDateTime(dr["FecNacimiento"]),
                        Direccion = dr["Direccion"].ToString(),
                        Email = dr["Email"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Foto = Image.FromStream(ms),
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

        public bool ActualizarEstudiante(Estudiante e)
        {
            bool exito = false;
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("uspUpdateEstudiante", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@IdEstudiante", e.Id);
                cmd.Parameters.AddWithValue("@Telefono", e.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", e.Direccion);
                cmd.Parameters.AddWithValue("@Email", e.Email);
                cn.Open();
                var i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    exito = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally { cmd?.Connection.Close(); }
            return exito;
        }
    }
}
