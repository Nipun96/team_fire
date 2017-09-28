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
    public partial class vreserve : UserControl
    {
        private static vreserve _instance;
        public static vreserve Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new vreserve();

                return _instance;
                
            }
        }
       

        public vreserve()
        {
            InitializeComponent();
            //fillcombo();
        }
        void fillcombo()
        {
            String conString = "server=localhost;user id=root;database=custmandb";
            // Database db = new Database();

            string query = "select vehicleID from register where status='aviliable' ;";

            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conn);
           
            MySqlDataReader myreader;
            conn.Close();
          
            try
            {
                conn.Open();
                myreader = cmdDataBase.ExecuteReader();
                comboBox1.Items.Clear();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(0);
                    if (comboBox1.Items.Contains(sname))
                    {
                        
                        
                    }


                    else
                    {
                        comboBox1.Items.Add(sname);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void reserve_Load(object sender, EventArgs e)
       {
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
        }
                    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void vehicleID_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void search_OnTextChange(object sender, EventArgs e)
        {
           
        }

        private void endDate_onValueChanged(object sender, EventArgs e)
        {

            
            
          
            
            

        }

        private void endDate_onValueChanged_1(object sender, EventArgs e)
        {
            DateTime date1 = startDate.Value;
            DateTime date2 = endDate.Value;

            TimeSpan diff = date2 - date1;




            duration.Text = diff.TotalDays.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {


                Database1 db = new Database1();
                MySqlConnection conn = db.getConnection();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into reserved (vehicleID,startDate,endDate,projectID,projectName,duration) values('" + comboBox1.Text + "','" + startDate.Value.Date.ToString("yyyy-MM-dd") + "','" + endDate.Value.Date.ToString("yyyy-MM-dd") + "','" + projectID.Text + "','" + projectName.Text + "','" + duration.Text + "')";

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("The record wass inserterd success");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));

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
                cmd.CommandText = "update  register set status='Not aviliable' where vehicleID='" + comboBox1.Text + "'";

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("the record wass updated success");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));

            }

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void search_OnTextChange_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Database1 db = new Database1();

                string query = "select *from reserved where vehicleID like '%" + search.Text + "%'";

                MySqlConnection conn = db.getConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = table;
                vehicle_reserve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                vehicle_reserve.DataSource = bsource;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
