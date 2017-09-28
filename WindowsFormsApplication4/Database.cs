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
    class Database
    {
        //connect to database
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=custmandb");

        //insert method

        public void DBhand(String quary)
        {

            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            MySqlCommand cmd = con.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = quary;
                cmd.ExecuteNonQuery();

                MetroFramework.MetroMessageBox.Show(Maintaine.ActiveForm, "your details are successfully added.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception e1)
            {
                MetroFramework.MetroMessageBox.Show(Maintaine.ActiveForm, " " + e1, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            con.Close();

        }

        //update method
        public void Dbupdate(String quary)
        {

            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            MySqlCommand cmd = con.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = quary;
                cmd.ExecuteNonQuery();

                MetroFramework.MetroMessageBox.Show(Maintaine.ActiveForm, "your details are successfully Update.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception e1)
            {
                MetroFramework.MetroMessageBox.Show(Maintaine.ActiveForm, " " + e1, "Error , You can't Update, Try agin.. ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            con.Close();
        }
        public void Dbdelet(String quary)//delete
        {

            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            MySqlCommand cmd = con.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = quary;
                cmd.ExecuteNonQuery();

                MetroFramework.MetroMessageBox.Show(Maintaine.ActiveForm, "your details are successfully Delete.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception e1)
            {
                MetroFramework.MetroMessageBox.Show(Maintaine.ActiveForm, " " + e1, "Error , You can't delete, Try agin.. ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            con.Close();
        }


        //select quary method
        public DataSet dbse(String qu)
        {
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            try
            {
                MySqlCommand cmdg = con.CreateCommand();
                cmdg.Connection = con;
                cmdg.CommandType = CommandType.Text;

                cmdg.CommandText = qu;

                MySqlDataAdapter deta = new MySqlDataAdapter(cmdg);
                DataSet ds = new DataSet();
                deta.Fill(ds, "load");
                
                con.Close();
               return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing wrong. Please check your database connection.");
                DataSet ee = new DataSet();
                return ee;
            }

        }
        public String dbgett(string qu)
        {
            //String txt;
            // List<String> list = new List<string>();
            String gett;



            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }
            MySqlCommand cmd = con.CreateCommand();

            try
            {
               
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = qu;


                object p = cmd.ExecuteScalar();
                gett = p.ToString();
                con.Close();

             /*   while (p.Read())
                {
                    gett[1] =  p["T"];

                    // list.Add(p.GetString(0));
                }
                //txt = p.ToString();
                */

                con.Close();
                // return list.ToArray();
                return gett;
            }
            catch (Exception e )
            {
                MessageBox.Show("Somthing wrong. Please check your database connection."+e);

                return "Error";
            }

        }

    }
    //class generator
    //{
    //    public static void autoincrement(Control textbox)
    //    {
    //        SqlCommand cmd = new SqlCommand("select max(register) from vehicleID");
    //    }
    

}
