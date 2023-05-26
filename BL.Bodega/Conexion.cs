using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace BL.Bodega
{
    public class Conexion
    {
        private string Server { get; set; }
        private string Port { get; set; }
        private string Database { get; set; }
        private string User { get; set; }
        private string Password { get; set; }
        private string Ssl { get; set; }

        private static Conexion conn = null;

        private Conexion()
        {
            Server = "localhost";
            Port = "3306";
            Database = "bd_bodega_multicable";
            User = "root";
            Password = "rivera1529";
            //Ssl = "verifyfull";
        }

        public MySqlConnection CreateConnection()
        {
            MySqlConnection cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = $"SERVER={Server}; PORT={Port}; USERNAME={User}; PASSWORD={Password}; DATABASE={Database};";
            }
            catch (System.Exception e)
            {
                cadena = null;

                throw e;
            }

            return cadena;
        }

        public static Conexion GetConexion()
        {
            if (conn == null)
            {
                conn = new Conexion();
            }

            return conn;
        }

    }
}
