using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Telephone_directory.Manager
{
     class Connection: IDisposable
    {
        private string ConnectURL = "server=localhost;user=root;database = `telephone directory`;password=0000";
        private MySqlConnection connect;
        public Connection()
        {
            connect = new MySqlConnection(ConnectURL);
            connect.Open();
        }

        public void Dispose()
        {
            connect.Close();
        }
    }
}
