using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{

    public partial class vsr : UserControl
    {
        private static vsr _instance;
        public static vsr Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new vsr();
                return _instance;
            }
        }
        public vsr()
        {
            InitializeComponent();

            genarateID();
        }


        void fillcombo()
        {
            String conString = "server=localhost;user id=root;database=custmandb";
            // Database db = new Database();

            string query = "select vehicleID from register ;";

            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conn);

            MySqlDataReader myreader;
            conn.Close();

            try
            {
                conn.Open();
                myreader = cmdDataBase.ExecuteReader();
                // V_Id.Items.Clear();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(0);
                    if (V_Id.Items.Contains(sname))
                    {


                    }


                    else
                    {
                        V_Id.Items.Add(sname);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string serid = "SV";
        private void genarateID()
        {
            Database1 db = new Database1();
            MySqlConnection conn = db.getConnection();
            MySqlCommand cmd = new MySqlCommand("select Count(Serv_No) from services", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            Serv_No.Text = serid + i.ToString();

        }
        private void vsr_Load(object sender, EventArgs e)
        {

        }

        private void add1_Click(object sender, EventArgs e)
        {

            try
            {
                Database1 db = new Database1();
                MySqlConnection conn = db.getConnection();
                MySqlCommand cmd = conn.CreateCommand();
                fillcombo();
                cmd.CommandText = "insert into services (Serv_No,Next_Milage,Note,Services,Current_Milage,V_Id,sCost) values('" + Serv_No.Text + "','" + Convert.ToInt32(Next_Milage.Text) + "','" + Note.Text + "','" + Services.Text + "','" + Convert.ToInt32(Current_Milage.Text) + "','" + V_Id.Text + "','" + Convert.ToDouble(sCost.Text) + "')";
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

        private void add2_Click(object sender, EventArgs e)
        {
            try
            {
                Database1 db = new Database1();
                MySqlConnection conn = db.getConnection();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into repair (Rep_Id,Note,Rep_cost,V_Id) values('" + Rep_Id.Text + "','" + rNote.Text + "','" + Rep_Cost.Text + "','" + vId.Text + "')";
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

        private void Services_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string v = Services.SelectedIndex.ToString();
            int x = Convert.ToInt32(Services.SelectedIndex.ToString());
            if (x == 0)
            {

                sCost.Text = "1500";

                // sCost.Text = Services.SelectedIndex.ToString();



            }
            else if (x == 1)
            {
                sCost.Text = "600";
            }


        }

        private void V_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void Serv_No_Click(object sender, EventArgs e)
        {

        }

        private void V_Id_Click(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void V_Id_TextChanged(object sender, EventArgs e)
        {
            String conString = "server=localhost;user id=root;database=custmandb";
            // Database db = new Database();

            string query = "select vNo from register where vehicleID='" + V_Id.Text + "'";

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
                    vNo.Text = sname;


                }
            }
            catch { }
        }
    

    }
}

