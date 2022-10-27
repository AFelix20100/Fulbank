using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace projet_Fulbank.Class
{
    abstract public class DBConnexion
    {
        private static DBConnexion _instance = null;
        private static MySqlConnection conn;


        private static String setBDD()
        {
            string host = "192.168.0.18";
            string database = "fulbank";
            string port = "3306";
            string username = "fulbank";
            string password = "xeWE7u9";
            String connString = "Server=" + host + ";Database=" + database + ";port=" + port + ";User Id=" + username + ";password=" + password;
            return connString;
        }
        public static MySqlConnection getConnexion()
        {
            if (DBConnexion._instance == null)
            {
                conn = new MySqlConnection(setBDD());
            }
            return conn;
        }
    }
}
