using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryTest
{
    public class MySQLConnectionApp
    {
        public static MySqlConnection GetConnection()
        {
            string constructorString = "server=localhost;User Id=root;password=12345678;Database=authdb";
            MySqlConnection myConnnect = new MySqlConnection(constructorString);
            return myConnnect;
        }
    }
}
