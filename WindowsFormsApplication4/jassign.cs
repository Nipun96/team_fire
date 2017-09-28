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
using System.Data.SqlClient;


namespace WindowsFormsApplication4
{
    public partial class jassign : UserControl
    {
        MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database=custmandb");
        
        MySqlCommand command;
        MySqlDataReader mdr;
        private static jassign _instance;
        public static jassign Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new jassign();
                return _instance;
            }
        }
        public jassign()
        {
            InitializeComponent();
            generateID();
                       
        }
        String jbID = "ProjectID";
        private void generateID()
        {
            Database1 db = new Database1();
            MySqlConnection conn = db.getConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(JobID) from assignJobs", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            bunifuMaterialTextbox2.Text = jbID + i.ToString();
        }


        //-------------------------------------------------------------------------------
        public void fillcomboMachanic()
        {
            try
            {
                con.Open();
                String selectQ = "SELECT DISTINCT w_ID FROM details WHERE field='Electrical Technician' AND current_job ='No'";
                MySqlCommand cmd = new MySqlCommand(selectQ, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("w_ID"));
                    comboBox2.Items.Add(reader.GetString("w_ID"));
                    comboBox3.Items.Add(reader.GetString("w_ID"));
                    comboBox4.Items.Add(reader.GetString("w_ID"));
                    comboBox5.Items.Add(reader.GetString("w_ID"));
                    comboBox6.Items.Add(reader.GetString("w_ID"));
                    comboBox7.Items.Add(reader.GetString("w_ID"));
                    comboBox8.Items.Add(reader.GetString("w_ID"));
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //-----------------------------------------------------------------------------------------

        public void fillcombowaterMachanic()
        {
            try
            {
                con.Open();
                String selectQ = "SELECT DISTINCT w_ID FROM details WHERE field='Water Machanic' AND current_job ='No'";
                MySqlCommand cmd = new MySqlCommand(selectQ, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox25.Items.Add(reader.GetString("w_ID"));
                    comboBox26.Items.Add(reader.GetString("w_ID"));
                    comboBox27.Items.Add(reader.GetString("w_ID"));
                    comboBox28.Items.Add(reader.GetString("w_ID"));
                    comboBox29.Items.Add(reader.GetString("w_ID"));
                    comboBox30.Items.Add(reader.GetString("w_ID"));
                    comboBox31.Items.Add(reader.GetString("w_ID"));
                    comboBox32.Items.Add(reader.GetString("w_ID"));
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------
        public void fillcombotechnicion()
        {
            try
            {
                con.Open();
                String selectQ = "SELECT DISTINCT w_ID FROM details WHERE field='Technician' AND current_job ='No'";
                MySqlCommand cmd = new MySqlCommand(selectQ, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox9.Items.Add(reader.GetString("w_ID"));
                    comboBox10.Items.Add(reader.GetString("w_ID"));
                    comboBox11.Items.Add(reader.GetString("w_ID"));
                    comboBox12.Items.Add(reader.GetString("w_ID"));
                    comboBox13.Items.Add(reader.GetString("w_ID"));
                    comboBox14.Items.Add(reader.GetString("w_ID"));
                    comboBox15.Items.Add(reader.GetString("w_ID"));
                    comboBox16.Items.Add(reader.GetString("w_ID"));
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------
        public void fillcombolabers()
        {
            
            try
            {
                con.Open();
                String selectQ = "SELECT DISTINCT w_ID FROM details WHERE field='Labers' AND current_job ='No'";
                MySqlCommand cmd = new MySqlCommand(selectQ, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    
                    
                    comboBox17.Items.Add(reader.GetString("w_ID"));
                    comboBox18.Items.Add(reader.GetString("w_ID"));
                    comboBox19.Items.Add(reader.GetString("w_ID"));
                    comboBox20.Items.Add(reader.GetString("w_ID"));
                    comboBox21.Items.Add(reader.GetString("w_ID"));
                    comboBox24.Items.Add(reader.GetString("w_ID"));
                    comboBox25.Items.Add(reader.GetString("w_ID"));
                    comboBox26.Items.Add(reader.GetString("w_ID"));
                    
                }
                con.Close();                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //---------------------------------------------------------------------------------
        public void fillcombodriver()
        {

            try
            {
                con.Open();
                String selectQ = "SELECT DISTINCT w_ID FROM details WHERE field='Drivers' AND current_job ='No'";
                MySqlCommand cmd = new MySqlCommand(selectQ, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {


                    comboBox33.Items.Add(reader.GetString("w_ID"));
                    comboBox34.Items.Add(reader.GetString("w_ID"));
                    comboBox35.Items.Add(reader.GetString("w_ID"));
                    comboBox36.Items.Add(reader.GetString("w_ID"));
                    comboBox37.Items.Add(reader.GetString("w_ID"));
                    comboBox38.Items.Add(reader.GetString("w_ID"));
                    comboBox39.Items.Add(reader.GetString("w_ID"));
                    comboBox40.Items.Add(reader.GetString("w_ID"));

                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void assign_Load(object sender, EventArgs e)
        {
            clear();
            fillcomboMachanic();
            fillcombowaterMachanic();
            fillcombotechnicion();
            fillcombodriver();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox1.Text;
           if(comboBox2.Text ==temp || comboBox3.Text == temp || comboBox4.Text == temp || comboBox5.Text == temp || comboBox6.Text == temp || comboBox7.Text == temp || comboBox8.Text == temp )
            {                
                MessageBox.Show("Can't Assign one person twise");                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            fillcomboMachanic();
            fillcombowaterMachanic();
            fillcombotechnicion();
            fillcombolabers();
        }

        public void clear()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();
            comboBox9.Items.Clear();
            comboBox10.Items.Clear();
            comboBox11.Items.Clear();
            comboBox12.Items.Clear();
            comboBox13.Items.Clear();
            comboBox14.Items.Clear();
            comboBox15.Items.Clear();
            comboBox16.Items.Clear();
            comboBox17.Items.Clear();
            comboBox18.Items.Clear();
            comboBox19.Items.Clear();
            comboBox20.Items.Clear();
            comboBox21.Items.Clear();
            comboBox22.Items.Clear();
            comboBox23.Items.Clear();
            comboBox24.Items.Clear();
            comboBox25.Items.Clear();
            comboBox26.Items.Clear();
            comboBox27.Items.Clear();
            comboBox28.Items.Clear();
            comboBox29.Items.Clear();
            comboBox30.Items.Clear();
            comboBox31.Items.Clear();
            comboBox32.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "INSERT INTO details (p_ID) VALUES ('" + bunifuMaterialTextbox2.Text + "') WHERE w_ID='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success !");
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox2.Text;
            if (comboBox1.Text == temp || comboBox3.Text == temp || comboBox4.Text == temp || comboBox5.Text == temp || comboBox6.Text == temp || comboBox7.Text == temp || comboBox8.Text == temp)
            {
                MessageBox.Show("Can't Assign one person twise");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox3.Text;
            if (comboBox2.Text == temp || comboBox1.Text == temp || comboBox4.Text == temp || comboBox5.Text == temp || comboBox6.Text == temp || comboBox7.Text == temp || comboBox8.Text == temp)
            {
                MessageBox.Show("Can't Assign one person twise");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox4.Text;
            if (comboBox2.Text == temp || comboBox3.Text == temp || comboBox1.Text == temp || comboBox5.Text == temp || comboBox6.Text == temp || comboBox7.Text == temp || comboBox8.Text == temp)
            {
                MessageBox.Show("Can't Assign one person twise");
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox8.Text;
            if (comboBox2.Text == temp || comboBox3.Text == temp || comboBox4.Text == temp || comboBox5.Text == temp || comboBox6.Text == temp || comboBox7.Text == temp || comboBox1.Text == temp)
            {
                MessageBox.Show("Can't Assign one person twise");
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox7.Text;
            if (comboBox2.Text == temp || comboBox3.Text == temp || comboBox4.Text == temp || comboBox5.Text == temp || comboBox6.Text == temp || comboBox1.Text == temp || comboBox8.Text == temp)
            {
                MessageBox.Show("Can't Assign one person twise");
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox6.Text;
            if (comboBox2.Text == temp || comboBox3.Text == temp || comboBox4.Text == temp || comboBox5.Text == temp || comboBox1.Text == temp || comboBox7.Text == temp || comboBox8.Text == temp)
            {
                MessageBox.Show("Can't Assign one person twise");
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox5.Text;
            if (comboBox2.Text == temp || comboBox3.Text == temp || comboBox4.Text == temp || comboBox1.Text == temp || comboBox6.Text == temp || comboBox7.Text == temp || comboBox8.Text == temp)
            {
                MessageBox.Show("Can't Assign one person twise");
            }
        }
    }
}