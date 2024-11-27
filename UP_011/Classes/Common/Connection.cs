using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UP_011.Classes.Common
{
    public class Connection
    {
        public static readonly string config = "Server=127.0.0.1;port=3307;Database=UP_bd;uid=root";
        public static MySqlConnection OpenConnection()
        {
            MySqlConnection connection = new MySqlConnection(config);
            connection.Open();
            return connection;
        }
        public static MySqlDataReader Query(string str, MySqlConnection connection)
        {
            return new MySqlCommand(str, connection).ExecuteReader();
        }
        public static void CloseConnection(MySqlConnection connection)
        {
            connection.Close();
            MySqlConnection.ClearPool(connection);
        }
    }
}
