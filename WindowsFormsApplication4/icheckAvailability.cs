using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication4
{
    
    public partial class icheckAvailability : Form
    {
        Database db = new Database();

        string index;
        
        

        public icheckAvailability()
        {
            InitializeComponent();
        }

        private void orderId_check_Leave(object sender, EventArgs e)
        {
            if (orderId_check.Text == "")
            {
                orderId_check.Text = "Order Id";

                orderId_check.ForeColor = Color.Black;
            }
        }

        private void orderId_check_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void orderId_check_Enter(object sender, EventArgs e)
        {
            if (orderId_check.Text == "Order Id")
            {
                orderId_check.Text = "";

                orderId_check.ForeColor = Color.Black;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkAvailability_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DataSet ds = db.dbse("SELECT * FROM order_products WHERE orderId = '" + orderId_check.Text + "'");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                int r = e.RowIndex;
                DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[r];

                itemNameCheck.Text = selectedRow.Cells[1].Value.ToString();
                requiredCheck.Text = selectedRow.Cells[2].Value.ToString();

                int r1 = e.RowIndex;
                DataGridViewRow selectedRow1 = bunifuCustomDataGrid1.Rows[r1];

                index = selectedRow1.Cells[1].Value.ToString();

                string available_ = db.dbgett("select sum(quantity) from item where itemName = '" + index + "'");

                string rejected_ = db.dbgett("select sum(quantity) from rejected_item where item_name_reject = '" + index + "'");

                int final_available = Convert.ToInt32(available_);
                int final_rejected = Convert.ToInt32(rejected_);

                int total = final_available - final_rejected;


                if (total >= (Convert.ToInt32(requiredCheck.Text)))
                {
                    availableCheck.Text = Convert.ToString(total);
                }
                else
                {
                    int wanted = Convert.ToInt32(requiredCheck.Text) - total;
                    availableCheck.Text = Convert.ToString(total);
                    string qu = "insert into wanted (item_name_wanted,quantity) values('" + index + "','" + wanted + "')";
                    db.DBhand(qu);
                }
            }catch (Exception ee1)
            {
                MessageBox.Show("error : " + ee1, "Error");
            }




            //.Text = Convert.ToString(final_available);
            //textBox2.Text = Convert.ToString(final_rejected);



            //availableCheck.Text = available_;








        }

        private void availableCheck_OnValueChanged(object sender, EventArgs e)
        {

            
            


            string r = requiredCheck.Text;
            string a = availableCheck.Text;

            if (String.Compare(r, a) == 0)
            {
                status_check.Visible = false;
            }
            else if(String.Compare(r, a) == 1)
            {
                status_check.Visible = true;
            }
            else if(String.Compare(r, a) == 2)
            {
                status_check.Visible = false;
            }
            else
            {
                status_check.Visible = false;
            }
        }

        private void requiredCheck_OnValueChanged(object sender, EventArgs e)
        {

            string r = requiredCheck.Text;
            string a = availableCheck.Text;

            if (String.Compare(r, a) == 0)
            {
                status_check.Visible = false;
            }
            else if (String.Compare(r, a) == 1)
            {
                status_check.Visible = true;
            }
            else if (String.Compare(r, a) == 2)
            {
                status_check.Visible = false;
            }
        }
    }
}
