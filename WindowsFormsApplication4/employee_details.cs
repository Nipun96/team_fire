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
    public partial class employee_details : UserControl
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=empmn");
        MySqlCommand cmd;
        MySqlDataAdapter dr;
        private static employee_details _instance;
        public static employee_details Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new employee_details();
                return _instance;
            }
        }

        public employee_details()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void reserve_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string qu = "Update emp_reg SET fname = '" + fname.Text + "',cardid = '" + cardid.Text + "', lname = '" + lname.Text + "', address1 = '" + address1.Text + "', tel = '" + Telephone.Text + "', position= '" + position.Text + "', dob= '" + dob.Text + "',gender =  'M' ";
            db.Dbupdate(qu);
            //table12.DataSource = qu.Tables["load"];
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox9_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           
            
                Database db = new Database();
                DataSet ds = db.dbse("SELECT * FROM emp_reg WHERE nic ='" + search.Text + "'");
                table12.DataSource = ds.Tables["load"];
            
        
                
        
            //  fname.Text = Text = ds.Tables[0].Rows[1][0].ToString();
            // fname.DataBind();

            /*  try
                {
                    Database db = new Database();
                    // string query = "select *from register";
                    string query = "select *from emp_reg where fname like '%" + search.Text + "%'";




                    SqlConnection conn = db.getConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    BindingSource bsource = new BindingSource();
                    bsource.DataSource = table;
                    table12.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    table12.DataSource = bsource;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                */
        }

        private void table12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int r = e.RowIndex;
            DataGridViewRow selectedRow = table12.Rows[r];

            //fname.Text = selectedRow.Cells[0].Value.ToString();
            lname.Text = selectedRow.Cells[1].Value.ToString();
            dob.Text = selectedRow.Cells[2].Value.ToString();
            gender.Text = selectedRow.Cells[3].Value.ToString();
            nic.Text = selectedRow.Cells[7].Value.ToString();
            position.Text = selectedRow.Cells[9].Value.ToString();
            cardid.Text = selectedRow.Cells[10].Value.ToString();
            address1.Text = selectedRow.Cells[4].Value.ToString();
            Telephone.Text = selectedRow.Cells[8].Value.ToString();
            address2.Text = selectedRow.Cells[5].Value.ToString();
            city.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Database db = new Database();
           // DataSet ds = db.dbse("DELETE * FROM emp_reg WHERE nic ='" + search.Text + "'");
            // Database db = new Database();
            //DataSet ds = db.dbse("SELECT * FROM emp_reg WHERE nic ='" + search.Text + "'");
            //dg1.DataSource = ds.Tables["load"];

            Database db = new Database();
            string qu = ("DELETE  FROM emp_reg WHERE  nic ='" + search.Text + "'");
            db.Dbdelet(qu);
        }

        private void address2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           /* conn.Open();
            string selectQuery = "SELECT * FROM supply1 WHERE SupplierID=" + int.Parse(Search.Text);
            cmd = new MySqlCommand(selectQuery, conn);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                bunifuMaterialTextbox2.Text = dr.GetString("CompanyName");
                bunifuMaterialTextbox3.Text = dr.GetString("ContactName");
                bunifuMaterialTextbox4.Text = dr.GetString("Address");
                bunifuMaterialTextbox5.Text = dr.GetString("City");
                bunifuMaterialTextbox6.Text = dr.GetString("Region");
                bunifuMaterialTextbox7.Text = dr.GetString("Country");
                bunifuMaterialTextbox8.Text = dr.GetString("Phone");


            }

            else
            {
                Search.Text = " ";
                bunifuMaterialTextbox2.Text = " ";
                bunifuMaterialTextbox3.Text = " ";
                bunifuMaterialTextbox4.Text = " ";
                bunifuMaterialTextbox5.Text = " ";
                bunifuMaterialTextbox6.Text = " ";
                bunifuMaterialTextbox7.Text = " ";
                bunifuMaterialTextbox8.Text = " ";
                MessageBox.Show("No Data for This ID", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
            con.Close();*/
        }

        private void search_Enter(object sender, EventArgs e)
        {
            if (search.Text == "Enter nic num")
            {
                search.Text = "";
                search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Enter nic num";
                search.ForeColor = Color.Black;
            }
        }
    }
    }
