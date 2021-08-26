using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        #region "Patron Singleton"
        private static Conexion conexion = null;
        private Conexion(){}

        public static Conexion getInstance()
        {
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }
        #endregion

        public SqlConnection ConexionDB()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=LAPTOP-GT8CUF55\SQLEXPRESS;Initial Catalog=DBClinica;Integrated Security=True";
            return conexion;
        }
    }
}
