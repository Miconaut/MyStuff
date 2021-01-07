using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp_1_1
{
    class DB
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=csharp_users_db");
    
        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
