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
    public partial class worker_sdetails : UserControl
    {
        MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database=custmandb");
        MySqlCommand command;        
        MySqlDataReader mdr;
                
        private static worker_sdetails _instance;
        public static worker_sdetails Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new worker_sdetails();
                return _instance;
            }
        }
        public worker_sdetails()
        {
            InitializeComponent();
            fillcombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                String selecq = "UPDATE details SET w_ID='" + materialSingleLineTextField1.Text + "', field='"+ comboBox1.Text + "',time='"+ bunifuMaterialTextbox1.Text + "',current_job='"+ bunifuMaterialTextbox2.Text + "' WHERE w_ID='"+ materialSingleLineTextField1.Text + "'";
                command = new MySqlCommand(selecq, con);
                mdr = command.ExecuteReader();
                MessageBox.Show("SuccesFull Updated");
                comboBox1.Text = null;
                bunifuMaterialTextbox1.Text = null;
                bunifuMaterialTextbox2.Text = null;
                materialSingleLineTextField1.Text = null;
                con.Close();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text == null || materialSingleLineTextField1.Text == "Search")
            {
                MessageBox.Show("There is no Worker ID to search");
            }
            else
            {
                try
                {

                    con.Open();
                    String selecq = "SELECT * FROM details WHERE w_ID='" + materialSingleLineTextField1.Text + "'";
                    command = new MySqlCommand(selecq, con);
                    mdr = command.ExecuteReader();

                    if (mdr.Read())
                    {
                        MessageBox.Show("SuccesFull");

                        comboBox1.Text = mdr.GetString("field");
                        bunifuMaterialTextbox1.Text = mdr.GetString("time");
                        bunifuMaterialTextbox2.Text = mdr.GetString("current_job");

                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Your entered worker's ID is incorrect");
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void worker_sdetails_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
                try
                {
                    command = new MySqlCommand();
                    command.Connection = con;
                    command.CommandText = "select * from details";
                    con.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        bunifuCustomDataGrid1.DataSource = dt;
                    }
                con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox2_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox2_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("This worker assigned to job or not?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(re == DialogResult.Yes)
            {
                bunifuMaterialTextbox2.Text = "Yes";
            }
            else if (re == DialogResult.No)
            {
                bunifuMaterialTextbox2.Text = "No";
            }
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            materialSingleLineTextField1.Clear();
        }

        private void materialSingleLineTextField1_Enter(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text == null || materialSingleLineTextField1.Text == "Search")
            {
                MessageBox.Show("There is no Worker ID to search");
            }
            else
            {
                try
                {

                    con.Open();
                    String selecq = "SELECT * FROM details WHERE w_ID='" + materialSingleLineTextField1.Text + "'";
                    command = new MySqlCommand(selecq, con);
                    mdr = command.ExecuteReader();

                    if (mdr.Read())
                    {
                        MessageBox.Show("SuccesFull");

                        //bunifuMaterialTextbox3.Text = mdr.GetString("field");
                        bunifuMaterialTextbox1.Text = mdr.GetString("time");
                        bunifuMaterialTextbox2.Text = mdr.GetString("current_job");

                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Your entered worker's ID is incorrect");
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void materialSingleLineTextField1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void materialSingleLineTextField1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (materialSingleLineTextField1.Text == null || materialSingleLineTextField1.Text == "Search")
                {
                    MessageBox.Show("There is no Worker ID to search");
                }
                else
                {
                    try
                    {

                        con.Open();
                        String selecq = "SELECT * FROM details WHERE w_ID='" + materialSingleLineTextField1.Text + "'";
                        command = new MySqlCommand(selecq, con);
                        mdr = command.ExecuteReader();

                        if (mdr.Read())
                        {
                            MessageBox.Show("SuccesFull");

                            comboBox1.Text = mdr.GetString("field");
                            bunifuMaterialTextbox1.Text = mdr.GetString("time");
                            bunifuMaterialTextbox2.Text = mdr.GetString("current_job");

                            con.Close();
                        }
                        else
                        {
                            
                            MessageBox.Show("Your entered worker's ID is incorrect");
                        }
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void fillcombo()
        {
            try
            {
                con.Open();
                String selectQ = "SELECT * FROM Fields";
                MySqlCommand cmd = new MySqlCommand(selectQ,con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("fields"));
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*comboBox1.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT fields FROM Fields";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["fields"].ToString());
            }

            con.Close(); 
            -----------------------------------
            String conS = "server = localhost; user id = root; database=jobhd;allowuservariables=True";
            String query = "SELECT fields FROM Fields";
            MySqlConnection conn = new MySqlConnection(conS);
            MySqlCommand cmdData = new MySqlCommand(query, conn);
            MySqlDataReader myreader;
            conn.Close();

            try
            {
                conn.Open();
                myreader = cmdData.ExecuteReader();
                while (myreader.Read())
                {
                    String name = myreader.GetString(0);
                    comboBox1.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  */
        }
    }
}
