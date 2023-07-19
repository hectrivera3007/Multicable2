using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;


namespace BL.Bodega
{

    public static class ConexionBD
    {
        private static string connectionString = "Server = (localdb)\\CATELSA; database=CATELSA-MULTICABLE; Integrated Security = true;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la conexión: " + ex.ToString());
                return null;
            }
        }

        public static void CerrarConexion(SqlConnection connection)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }

}
