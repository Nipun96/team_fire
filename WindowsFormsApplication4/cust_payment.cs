using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using MetroFramework;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{

    public partial class cust_payment : UserControl
    {

        private static cust_payment _instance;
        Database db = new Database();
        public static cust_payment Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new cust_payment();
                return _instance;
            }
        }
        public cust_payment()
        {
            InitializeComponent();
            
        }

        void load()
        {
            DataSet ds = db.dbse("SELECT * FROM acceptedpay");
            
            DataTable table = new DataTable();
          
            BindingSource bsource = new BindingSource();
            
            paymentTable.DataSource = ds.Tables["load"];
           

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            DataGridViewRow selectedRow = AcceptedPayment.Rows[r];

           
            textbox3.Text = selectedRow.Cells[1].Value.ToString();
            textbox2.Text = selectedRow.Cells[2].Value.ToString();
            textbox1.Text = selectedRow.Cells[3].Value.ToString();
            textboxest.Text = selectedRow.Cells[4].Value.ToString();
        }

        private void payment_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
     
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {

                String qu = "INSERT INTO custmandb.payment(fullname,sDate,eDate,amount,method,toBPaid) VALUES('" + textbox3.Text + "', '" + textbox2.Text + "', '" + textbox1.Text + "', '" + textbox4.Text + "', '" + comboBox1.Text + "', '" + textbox6.Text + "') "; //change table name and DB name
                db.DBhand(qu);
                
           
   
                MessageBox.Show("The request was added successfully");

            }
            catch (SqlException ex)
            {

                MessageBox.Show(Convert.ToString(ex));
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            try {
                //estimated amount- amount paid
                if (!string.IsNullOrEmpty(textboxest.Text) && !string.IsNullOrEmpty(textbox4.Text))
                {
                    textbox6.Text = (Convert.ToInt32(textboxest.Text) - Convert.ToInt32(textbox4.Text)).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("claculation Error"+ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM acceptedpay WHERE fullname='" + paysearch.Text + "'");
            AcceptedPayment.DataSource = ds.Tables["load"];
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textbox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textbox2_Click(object sender, EventArgs e)
        {

        }

        private void textbox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textbox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textbox6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textboxest_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM acceptedpay");
            AcceptedPayment.DataSource = ds.Tables["load"];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            load();
            //Database db = new Database();
            //DataSet ds = db.dbse("SELECT * FROM payment");
            //paymentTable.DataSource = ds.Tables["load"];
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox2.Clear();
            textbox3.Clear();
            textbox4.Clear();
            textboxest.Clear();
            textbox6.Clear();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM payment WHERE fullname='" + paymentsearch.Text + "'");
            paymentTable.DataSource = ds.Tables["load"];
        }

        private void paymentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textbox3_Enter(object sender, EventArgs e)
        {
            if (textbox3.Text == "Enter full name")
            {
                textbox3.Text = "";
                textbox3.ForeColor = Color.Black;
            }
        }

        private void textbox2_Enter(object sender, EventArgs e)
        {
            if (textbox2.Text == "Enter starting date")
            {
                textbox2.Text = "";
                textbox2.ForeColor = Color.Black;
            }
        }

        private void textbox1_Enter(object sender, EventArgs e)
        {
            if (textbox1.Text == "Enter endiing Date")
            {
                textbox1.Text = "";
                textbox1.ForeColor = Color.Black;
            }
        }

        private void textboxest_Enter(object sender, EventArgs e)
        {
            if (textboxest.Text == "Enter estimated amount")
            {
                textboxest.Text = "";
                textboxest.ForeColor = Color.Black;
            }
        }

        private void textbox4_Enter(object sender, EventArgs e)
        {
            if (textbox4.Text == "Enter paying amount")
            {
                textbox4.Text = "";
                textbox4.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Enter payment method")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void textbox6_Enter(object sender, EventArgs e)
        {
            if (textbox6.Text == "Remaining amount to be paid")
            {
                textbox6.Text = "";
                textbox6.ForeColor = Color.Black;
            }
        }

        private void textbox3_Leave(object sender, EventArgs e)
        {
            if (textbox3.Text == "")
            {
                textbox3.Text = "Enter full name";
                textbox3.ForeColor = Color.DimGray;
            }
        }

        private void textbox2_Leave(object sender, EventArgs e)
        {
            if (textbox2.Text == "")
            {
                textbox2.Text = "Enter starting date";
                textbox2.ForeColor = Color.DimGray;
            }
        }

        private void textbox1_Leave(object sender, EventArgs e)
        {
            if (textbox1.Text == "")
            {
                textbox1.Text = "Enter endiing Date";
                textbox1.ForeColor = Color.DimGray;
            }

        }

        private void textboxest_Leave(object sender, EventArgs e)
        {
            if (textboxest.Text == "")
            {
                textboxest.Text = "Enter estimated amount";
                textboxest.ForeColor = Color.DimGray;
            }

        }

        private void textbox4_Leave(object sender, EventArgs e)
        {
            if (textbox4.Text == "")
            {
                textbox4.Text = "Enter paying amount";
                textbox4.ForeColor = Color.DimGray;
            }

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Enter payment method";
                comboBox1.ForeColor = Color.DimGray;
            }
        }

        private void textbox6_Leave(object sender, EventArgs e)
        {
            if (textbox6.Text == "")
            {
                textbox6.Text = "Remaining amount to be paid";
                textbox6.ForeColor = Color.DimGray;
            }
        }
    }
}
