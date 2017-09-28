using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class DBConnecton
    {
        public static string connection = "server=localhost;user id=root;database=custmandb";

        public MySqlConnection DBConnection()
        {
            MySqlConnection DBConnect = new MySqlConnection("server=localhost;user id=root;database=custmandb");
            DBConnect.Open();
           return DBConnect;


        }
    }

}
