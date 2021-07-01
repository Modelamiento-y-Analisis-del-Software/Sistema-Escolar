using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
namespace CapaDatos
{
    class SqlCurso
    {
        public static SqlCurso Instancia { get; } = new SqlCurso();
        public bool InsertarCurso(Curso cu)
        {
            var exito = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("uspCurso", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Nombre", cu.Nombre);
                cmd.Parameters.AddWithValue("@Dni",cu.EntDocente.Dni);
                cmd.Parameters.AddWithValue("@GradoEscolar", m.GradoEscolar);
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
