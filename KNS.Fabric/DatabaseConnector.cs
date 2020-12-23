using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNS.Fabric
{
    class DatabaseConnector
    {
        public static string ConnectionString = "server=127.0.0.1;port=3306;database=kns_fabric;uid=kns; password = ";
        public static MySqlConnection CreateConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
