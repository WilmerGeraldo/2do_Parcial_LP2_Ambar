using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySql.Data;
using System.Security.Permissions;
using System.Security.Policy;

namespace _2do_Parcial_LP2.ConexionDB
{
    internal class ConexionAmbarDB
    {
        public MySqlConnection AmbarConex = new MySqlConnection();
        static string server = "127.0.0.1";
        static string dataBase = "ambar_comercialdb";
        static string user = "root";
        static string password = "1604";
        static string port = "3306";

        public MySqlConnection EstablecerConexion()
        {
            try
            {
                if(Environment.UserDomainName == "LAPTOP-573KV0C0")
                {
                    server = "localhost";
                    password = "wilsju26";
                }
                else
                {
                    server = "127.0.0.1";
                    password = "1604";
                }

                string ConectionString = $"server={server}; database={dataBase}; user={user}; password={password}; port={port}";

                if(AmbarConex.State != ConnectionState.Open)
                {
                    AmbarConex.ConnectionString = ConectionString;
                    AmbarConex.Open();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error al conectarse con la Base de Datos");
            }
            return AmbarConex;
        }

        public void CerrarConexion()
        {
            if (AmbarConex.State == ConnectionState.Open)
            {
                AmbarConex.Close();
            }
        }
    }
}
