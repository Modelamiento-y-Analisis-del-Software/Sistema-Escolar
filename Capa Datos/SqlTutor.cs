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
        public bool InsertarTutor(Tutor t, Estudiante e, string parentesco)
        {
            bool exito = false;
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("uspInsertarTutor", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Dni", t.Dni);
                cmd.Parameters.AddWithValue("@Nombres", t.Nombres);
                cmd.Parameters.AddWithValue("@ApPaterno", t.ApPaterno);
                cmd.Parameters.AddWithValue("@ApMaterno", t.ApMaterno);
                cmd.Parameters.AddWithValue("@Sexo", t.Sexo);
                cmd.Parameters.AddWithValue("@FecNacimiento", t.FecNacimiento);
                cmd.Parameters.AddWithValue("@Direccion", t.Direccion);
                cmd.Parameters.AddWithValue("@Email", t.Email);
                cmd.Parameters.AddWithValue("@Telefono", t.Telefono);
                cmd.Parameters.AddWithValue("@Ocupacion", t.Ocupacion);
                cmd.Parameters.AddWithValue("@NvAcademico", t.NvAcademico);
                cmd.Parameters.AddWithValue("@IdEstudiante", e.Id);
                cmd.Parameters.AddWithValue("@parentesco", parentesco);
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