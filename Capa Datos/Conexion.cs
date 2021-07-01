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
            //String cnxnString =
            //"Data Source=DESKTOP-RLKQH58\\SERVIDOR_1;" +
            //"Initial Catalog=IntegralClass" +
            //"User id=sa" +
            //"Password=159753456852" +
            //"Integrated Security=true";
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = "Data Source=.; Initial Catalog=IntegralClass; Integrated Security=true"
                //ConnectionString = cnxnString
            };
            return cn;
        }
    }
}
