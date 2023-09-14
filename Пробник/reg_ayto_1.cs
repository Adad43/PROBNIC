using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Пробник
{
    class reg_ayto_1
    {
        MySqlConnection connect;
        MySqlConnectionStringBuilder connectString;
        public reg_ayto_1()
        {
            connectString = new MySqlConnectionStringBuilder();

            connectString.Database = "kyrsah";
            connectString.UserID = "root";
            connectString.Password = "Adad4320033002";
            connectString.Server = "localhost";

            connect = new MySqlConnection(connectString.ConnectionString);
        }
        public bool AVTO(string login, string password)
        {
            int res;

            connect = new MySqlConnection(connectString.ConnectionString);
            connect.Open();
            string cndText = $"SELECT COUNT(*) FROM kyrsah.user WHERE login = '{login}' && password = '{password}';";

            MySqlCommand sqlDa = new MySqlCommand(cndText, connect);
            res = int.Parse(sqlDa.ExecuteScalar().ToString());

            connect.Close();
            if (res > 0) return true;
            else return false;
        }
        public int AddUser(string login, string password)
        {
            var check = -1;
            MySqlConnection connection = new MySqlConnection(connectString.ConnectionString);
            connection.Open();
            string cndText = "INSERT INTO kyrsah.user(login,password)" +
                $"VALUES ('{login}','{password}');";

            MySqlCommand cmd = new MySqlCommand(cndText, connection);
            check = cmd.ExecuteNonQuery();

            connection.Close();
            return check;
        }
    }
}
