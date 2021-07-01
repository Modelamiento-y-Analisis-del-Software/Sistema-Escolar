using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using CapaEntidad;
namespace CapaDatos
{
    public class SqlDocente
    {
        public static SqlDocente Instancia { get; } = new SqlDocente();

        public List<Docente> ListarDocentes ()
        {
            SqlCommand cmd = null;
            var lista = new List<Docente>();
            try
            {
                var cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspListarDocente", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var ms = new MemoryStream((byte[])dr["Foto"]);
                    var d = new Docente();
                        d.Id = Convert.ToInt32(dr["IdDocente"]);
                        d.Dni = dr["Dni"].ToString();
                        d.Nombres = dr["Nombres"].ToString();
                        d.ApPaterno = dr["ApPaterno"].ToString();
                        d.ApMaterno = dr["ApMaterno"].ToString();
                        d.Sexo = dr["Sexo"].ToString().ElementAt(0);
                        d.FecNacimiento = Convert.ToDateTime(dr["FecNacimiento"]);
                        d.Direccion = dr["Direccion"].ToString();
                        d.Email = dr["Email"].ToString();
                        d.Telefono = dr["Telefono"].ToString();
                        d.Especialidad = Convert.ToInt32(dr["Especialidad"]);
                        d.Foto = Image.FromStream(ms);
                    lista.Add(d);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd?.Connection.Close(); }
            return lista;
        }

        public bool InsertarDocentes (Docente D)
        {
            bool exito = false;
            SqlCommand cmd = null;

            ImageConverter converter = new ImageConverter();
            var imgbytes = (byte[])converter.ConvertTo(D.Foto, typeof(byte[]));

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("uspInsertarDocente", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Dni", D.Dni);
                cmd.Parameters.AddWithValue("@Nombres", D.Nombres);
                cmd.Parameters.AddWithValue("@ApPaterno", D.ApPaterno);
                cmd.Parameters.AddWithValue("@ApMaterno", D.ApMaterno);
                cmd.Parameters.AddWithValue("@Sexo", D.Sexo);
                cmd.Parameters.AddWithValue("@FecNacimiento", D.FecNacimiento);
                cmd.Parameters.AddWithValue("@Direccion", D.Direccion);
                cmd.Parameters.AddWithValue("@Email", D.Email);
                cmd.Parameters.AddWithValue("@Telefono", D.Telefono);
                cmd.Parameters.AddWithValue("@Especialidad", D.Especialidad);
                cmd.Parameters.AddWithValue("@Foto", imgbytes);
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

        public List<Docente> BuscarDocentes(string dni)
        {
            SqlCommand cmd = null;
            var lista = new List<Docente>();
            try
            {
                var cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspSearchDocente", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Dni", dni);

                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var ms = new MemoryStream((byte[])dr["Foto"]);
                    var e = new Docente
                    {
                        Id = Convert.ToInt32(dr["IDDocente"]),
                        Dni = dr["Dni"].ToString(),
                        Nombres = dr["Nombre"].ToString(),
                        ApPaterno = dr["ApPaterno"].ToString(),
                        ApMaterno = dr["ApMaterno"].ToString(),
                        Sexo = dr["Sexo"].ToString().ElementAt(0),
                        FecNacimiento = Convert.ToDateTime(dr["FecNacimiento"]),
                        Direccion = dr["Direccion"].ToString(),
                        Email = dr["Email"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Especialidad = Convert.ToInt32(dr["Especialidad"]),
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
    }
}
