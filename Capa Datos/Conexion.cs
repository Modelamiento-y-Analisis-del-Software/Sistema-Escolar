using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
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
            String cnxnString =
            "Data Source=moansoupn.database.windows.net" +
            "Initial Catalog=IntegralClass" +
            "User id=kireb1298" +
            "Password=hew7DRUK_guf.cle­" +
            "Integrated Security=true";

            string test = "Server=tcp:moansoupn.database.windows.net,1433;Initial Catalog=IntegralClass;Persist Security Info=False;User ID=kireb1298;Password=hew7DRUK_guf.cle;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection cn = new SqlConnection
            {
                //ConnectionString = "Data Source=.; Initial Catalog=IntegralClass; Integrated Security=true"
                ConnectionString = test,
            };
            return cn;
        }
    }
}
