using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    class Database1
    {
        private static String conString = "server=localhost;user id=root;database=custmandb";
        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        private DataTable dt;

        public object Parameters { get; internal set; }

        public Database1()
        {
            try
            {
                con = new MySqlConnection(conString);
                con.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public String getConnectionString()
        {
            return conString;
        }

        public MySqlConnection getConnection()
        {
            return con;
        }

        public void sqlQuery(String query)
        {
            cmd = new MySqlCommand(query);
        }

        public DataTable executeQuery()
        {
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void nonQuery()
        {
            cmd.ExecuteNonQuery();
        }

        internal void sqlQuery(object query)
        {
            throw new NotImplementedException();
        }
    }


}
