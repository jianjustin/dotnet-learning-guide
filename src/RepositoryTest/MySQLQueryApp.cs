using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryTest
{
    public class MySQLQueryApp
    {
        public static void QueryUser(MySqlConnection connection)
        {
            var transaction = connection.BeginTransaction();

            string sql = "select * from user";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32("id") + reader.GetString("name") + reader.GetString("password"));//"userid"是数据库对应的列名，推荐这种方式
            }

            transaction.Commit();
        }

        public static void InsertUser(MySqlConnection connection)
        {
            string sql = @"insert into user(name,password)values(?name,?password)";
            MySqlParameter[] msp = new MySqlParameter[]
            {
                    new MySqlParameter("?name","jian"),
                    new MySqlParameter("?password","password")
            };
            MySqlHelper.ExecuteNonQuery(connection, sql, msp);
        }
    }
}
