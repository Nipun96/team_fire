using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class attendanceCheck
    {

        string ConnectionString = "server=localhost;user id=root;database=tftemdb";
        SqlConnection conn;

        public void OpenConnection()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
        }


        public void CloseConnection()
        {
            conn.Close();
        }

        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, conn);
            cmd.ExecuteNonQuery();
        }

        // read data from table 
        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;

        }
       

    }

}

