using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class cost : UserControl
    {
        Database1 db = new Database1();
        private static cost _instance;
        public static cost Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new cost();
                return _instance;
            }
        }
        public cost()
        {
            InitializeComponent();
           //illcombo();
            genarateID();
        }
        string incomeid = "VC";
        private void genarateID()
        {
            Database1 db = new Database1();
            MySqlConnection conn = db.getConnection();
            MySqlCommand cmd = new MySqlCommand("select count(incomeID) from vincome", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            incomeID1.Text = incomeid + i.ToString();

        }




        string estimation1 = "ES";
        private void genarateID1()
        {
            
            Database1 db = new Database1();
            MySqlConnection conn = db.getConnection();
            MySqlCommand cmd = new MySqlCommand("select count(estimationID) from vestimation", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            estimation1 = estimation1 + i.ToString();

        }



        void fillcombo()
        {
            String conString = "server=localhost;user id=root;database=custmandb";
            // Database db = new Database();

            string query = "select RE.projectID ,r.status from register r, reserved RE where RE.vehicleID = r.vehicleID and r.status = 'not aviliable'";
            

            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conn);
            // SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            MySqlDataReader myreader;
            conn.Close();
            try
            {
                conn.Open();
                myreader = cmdDataBase.ExecuteReader();
              //projectID.Items.Clear();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(0);
                    if (projectID.Items.Contains(sname))
                    {

                    }
                    else
                    {
                        projectID.Items.Add(sname);
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }
        void fillcost()
        {
            String conString = "server=localhost;user id=root;database=custmandb";
            // Database db = new Database();

            string query = "select duration from reserved where projectID='" + projectID.Text + "'";

            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conn);
            // SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            MySqlDataReader myreader;
            conn.Close();
            try
            {
                conn.Open();
                myreader = cmdDataBase.ExecuteReader();
                while (myreader.Read())
                {
                    string fname = myreader.GetString(0);
                    duration.Text = fname;


                }
            }
            catch { }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt1_Click(object sender, EventArgs e)
        {

        }

        private void projectID_TextChanged(object sender, EventArgs e)
        {
            String conString = "server=localhost;user id=root;database=custmandb";
            // Database db = new Database();

            string query = "select vehicleID from reserved where projectID='"+ projectID.Text +"'";

            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conn);
            // SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            MySqlDataReader myreader;
            conn.Close();
            try
            {
                conn.Open();
                myreader = cmdDataBase.ExecuteReader();
               
                while (myreader.Read())
                {
                    string sname = myreader.GetString(0);
                    vehicleID.Text = sname;
                    

                }
            }
            catch { }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            try
            {
                float km = float.Parse(milage.Text);
                float cost = float.Parse(duration.Text);
                float total1 = cost * 3 + 1000 + (km / 100 * 10);
                total.Text = total1.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                Database1 db = new Database1();
                //string query = "select *from Employee";
                MySqlConnection conn = db.getConnection();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "update  register set status='Aviliable' where vehicleID='" + vehicleID.Text + "'";

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("the record wass updated success");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));

            }
            try
            {
                Database1 db = new Database1();
                MySqlConnection conn = db.getConnection();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into vincome (incomeID,projectID,vehicleID,duration) values('" + incomeID1.Text + "','" + projectID.Text + "','" + vehicleID.Text + "','" + Convert.ToInt32(duration.Text) + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                genarateID();
                MessageBox.Show("Success");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            vehicleID.Clear(); 
            duration.Clear();
        }

        private void cost_Load(object sender, EventArgs e)
        {

           
        }

        private void fualcost_Click(object sender, EventArgs e)
        {

        }

        private void vehicleID_TextChanged(object sender, EventArgs e)
        {
            fillcost();
        }

        private void projectID_Click(object sender, EventArgs e)
        {
            // projectID.Items.Clear();
            fillcombo();


        }

        private void estimation_Click(object sender, EventArgs e)
        {

            try
            {
                float cost = float.Parse(duration.Text);
                float total1 = cost * 3 + 1000;
                // int x;
                total.Text = total1.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                Database1 db = new Database1();
                MySqlConnection conn = db.getConnection();
                MySqlCommand cmd = conn.CreateCommand();
                genarateID1();
                cmd.CommandText = "insert into vestimation (estimationID,projectID,vehicleID,estCost) values('" + estimation1 + "','" + projectID.Text + "','" + vehicleID.Text + "','" + double.Parse(total.Text) + "')";
                
                cmd.ExecuteNonQuery();
                conn.Close();
               
                MessageBox.Show("Success");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
