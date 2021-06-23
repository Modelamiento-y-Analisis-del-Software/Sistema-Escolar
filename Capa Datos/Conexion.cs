using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    class Conexion
    {
        private static readonly Conexion _instancia = new Conexion();
        #region singleton
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        #endregion singleton

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = "Data Source=.; Initial Catalog=SistemaVenta; Integrated Security=true"
            };
            return cn;
        }
    }
}
