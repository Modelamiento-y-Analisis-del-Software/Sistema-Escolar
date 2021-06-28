using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

                    m.Estudnte = e;

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

        public bool InsertarMatricula(Matricula m)
        {
            var exito = false;
            SqlCommand cmd = null;
            ImageConverter converter = new ImageConverter();
            var imgbytes = (byte[])converter.ConvertTo(m.Estudnte.Foto, typeof(byte[]));
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("uspMatricular", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Dni", m.Estudnte.Dni);
                cmd.Parameters.AddWithValue("@Nombres", m.Estudnte.Nombres);
                cmd.Parameters.AddWithValue("@ApPaterno", m.Estudnte.ApPaterno);
                cmd.Parameters.AddWithValue("@ApMaterno", m.Estudnte.ApMaterno);
                cmd.Parameters.AddWithValue("@Sexo", m.Estudnte.Sexo);
                cmd.Parameters.AddWithValue("@FecNacimiento", m.Estudnte.FecNacimiento);
                cmd.Parameters.AddWithValue("@Direccion", m.Estudnte.Direccion);
                cmd.Parameters.AddWithValue("@Email", m.Estudnte.Email);
                cmd.Parameters.AddWithValue("@Telefono", m.Estudnte.Telefono);
                cmd.Parameters.AddWithValue("@Foto", imgbytes);
                cmd.Parameters.AddWithValue("@GradoEscolar", m.GradoEscolar);
                cmd.Parameters.AddWithValue("@Seccion", m.Seccion);
                cmd.Parameters.AddWithValue("@Turno", m.Turno);
                cmd.Parameters.AddWithValue("@EscuelaProc", m.EscuelaProcedencia);
                cmd.Parameters.AddWithValue("@FecInscripcion", m.FecInscripcion);
                cmd.Parameters.AddWithValue("@Estado", m.Estado);
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
