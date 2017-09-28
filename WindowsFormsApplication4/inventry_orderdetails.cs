using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class inventry_orderdetails : UserControl
    {
        Database db = new Database();

        private static inventry_orderdetails _instance;
        public static inventry_orderdetails Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new inventry_orderdetails();
                return _instance;
            }
        }

        public inventry_orderdetails()
        {
            InitializeComponent();
        }



        private void orderdetails_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            if (sort.selectedIndex == 3)
            {
                date_sort.Visible = true;
                label1.Visible = true;

            }
            else
            {
                date_sort.Visible = false;
                label1.Visible = false;
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            icheckAvailability ch = new icheckAvailability();
            ch.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void stockNo_Enter(object sender, EventArgs e)
        {
            if (orderId.Text == "Order Id")
            {
                orderId.Text = "";

                orderId.ForeColor = Color.Black;
            }
        }

        private void stockNo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void orderId_Leave(object sender, EventArgs e)
        {
            if (orderId.Text == "")
            {
                orderId.Text = "Order Id";

                orderId.ForeColor = Color.Black;
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DataSet ds = db.dbse("SELECT * FROM order_details WHERE orderId = '" + orderId.Text + "'");
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }

        private void orderId_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sort.selectedIndex == 0)
            {
                string date_sort = DateTime.Now.Date.ToString("yyyy-MM-dd");
                textBox1.Text = date_sort;
                DataSet ds = db.dbse("SELECT * FROM order_details WHERE dueDate = '" + date_sort + "'");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
            }
            else if(sort.selectedIndex == 1)
            {
                string start_date = DateTime.Now.Date.ToString("yyyy-MM-");
                DataSet ds = db.dbse("SELECT * FROM order_details WHERE dueDate between '" +start_date+ "'00 and '"+start_date+"'30");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];

            }else if(sort.selectedIndex == 2)
            {
                DataSet ds = db.dbse("SELECT * FROM order_details WHERE dueDate = '" + date_sort.Value.Date.ToString("yyyy-MM-dd") + "'");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
            }
            

            
        }
    }
}
