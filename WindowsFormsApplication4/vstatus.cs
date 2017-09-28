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
using System.IO;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{

    public partial class vstatus : UserControl
    {
        private static vstatus _instance;
      

        public static vstatus Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new vstatus();
                return _instance;
            }
        }
 
        public vstatus()
    {
        InitializeComponent();
    }

        private void status_Load(object sender, EventArgs e)

        {



        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Database1 db = new Database1();
              
                string query = "select *from register where vNo like '%" + search.Text + "%'";

                MySqlConnection conn = db.getConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = table;
                vehicle_details.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                vehicle_details.DataSource = bsource;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                vehicle_reserved.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                vehicle_reserved.DataSource = bsource;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vehicle_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = vehicle_details.Rows[index];
            vehicleID.Text = selectedRow.Cells[0].Value.ToString();
            vNo.Text = selectedRow.Cells[1].Value.ToString();
            category.Text = selectedRow.Cells[2].Value.ToString();
            vModel.Text = selectedRow.Cells[3].Value.ToString();
            chassisNo.Text = selectedRow.Cells[4].Value.ToString();
            fuelType.Text = selectedRow.Cells[5].Value.ToString();
            engineNo.Text = selectedRow.Cells[6].Value.ToString();
            manufactYear.Text = selectedRow.Cells[7].Value.ToString();
            avilibility.Text = selectedRow.Cells[9].Value.ToString();

            try
            {



                Database1 db = new Database1();
                MySqlConnection conn = db.getConnection();
                MySqlCommand cmd = conn.CreateCommand();

                // string query = "select *from register";
                string sql = "select image from register where vNo='" + vNo.Text + "'";
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader DataRead = cmd.ExecuteReader();
                DataRead.Read();



                if (DataRead.HasRows)
                {
                    //vehicleID.Text = DataRead[0].ToString();
                    byte[] image1 = (byte[])(DataRead[0]);

                    if (imageBox == null)
                    {
                        imageBox.Image = null;
                    }
                    else
                    {
                        MemoryStream mstreem = new MemoryStream(image1);
                        imageBox.Image = Image.FromStream(mstreem);
                    }
                }

                else
                {
                    MessageBox.Show("Not Avilible");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                imageBox.Image = null;
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                Database1 db = new Database1();
                //string query = "select *from Employee";
                MySqlConnection conn = db.getConnection();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "update  register set vNo='" + vNo.Text + "',category='"+ category.Text + "',vModel='"+ vModel.Text + "',chassisNo='" + Convert.ToInt32(chassisNo.Text) + "',fuelType='" + fuelType.Text + "',engineNo='" + Convert.ToInt32(engineNo.Text) + "',manufactYear='" + manufactYear.Text + "' where vehicleID='" + vehicleID.Text + "'";

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("the record wass updated success");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vehicleID.Text = "";
            vNo.Text = "";
            category.Text = "";
            vModel.Text = "";
            chassisNo.Text = "";
            fuelType.Text = "";
            engineNo.Text = "";
            manufactYear.Text = "";
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void vehicle_reserved_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

