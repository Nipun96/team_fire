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
using System.Net;



namespace WindowsFormsApplication4
{

    
    public partial class cust_estimation : UserControl
    {
        //   MySqlConnection con = new MySqlConnection("datasource = localhost; port=3306;username=root;password=");



        private static cust_estimation _instance;
        Database db = new Database();
        public static cust_estimation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new cust_estimation();
                return _instance;
            }
        }
        public cust_estimation()
        {
            InitializeComponent();
        }



        private void estimation_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {

                this.Selecttype.Items.Clear();
                this.Selecttype.Items.Add("Select Items");
                this.Selecttype.Items.Add("aItem1");
                this.Selecttype.Items.Add("aItem2");
                this.Selecttype.Items.Add("aItem3");
                this.Selecttype.Items.Add("aItem4");
                this.Selecttype.Items.Add("aItem5");
                this.Selecttype.Items.Add("aItem6");

            }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM projectest WHERE fullname='" + sp.Text + "'");
            procost.DataSource = ds.Tables["load"];
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //insert Types of Data
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (textbox1.Text != "" && textbox2.Text != "" && textbox3.Text != "" && textBox4.Text != "" && textbox5.Text != "")
            {

                try
                {
                    float cost = 30 * 40; //calc for tot cost for equipments

                    //projectcost+ vehicle cost =service charge
                    if (!string.IsNullOrEmpty(textbox5.Text) && !string.IsNullOrEmpty(textbox6.Text))
                    {
                        String servecharge = (Convert.ToInt32(textbox5.Text) + Convert.ToInt32(textbox6.Text)).ToString();
                        String overallCost = cost + servecharge;



                        String q = "INSERT INTO custmandb.estimation(fullname,email,serviceType,Product,Quantity,Cost,ServiceCharge,Overallcost) VALUES('" + textbox1.Text + "', '" + textbox2.Text + "','" + textbox3.Text + "','" + Selecttype.Text + "','"+textBox4.Text+"','" + cost + "','" + servecharge + "','" + overallCost + "') ";
                        db.DBhand(q);


                      //  MessageBox.Show("The request was added successfully");
                    }

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
            }

        private void button6_Click(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox2.Clear();
            textbox3.Clear();
            textBox4.Clear();
            textbox5.Clear();
            textbox6.Clear();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            DataGridViewRow selectedRow = estreqsts.Rows[r];

            
            textbox1.Text = selectedRow.Cells[1].Value.ToString();
            textbox2.Text = selectedRow.Cells[2].Value.ToString();
            textbox3.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           

            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM requestforEsti WHERE fullname='" + se.Text + "'");
            estreqsts.DataSource = ds.Tables["load"];

            
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = e.RowIndex;
            DataGridViewRow selectedRow = procost.Rows[r];


            textbox5.Text = selectedRow.Cells[3].Value.ToString();
            
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            int r = e.RowIndex;
            DataGridViewRow selectedRow = vehiclecost.Rows[r];


            textbox6.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Database db = new Database();

            String qu = "DELETE  FROM estimation WHERE fullname= '" + se.Text + "'";
            db.Dbdelet(qu);

            MessageBox.Show("The request was removed successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage message = new MailMessage();
                message.From =new MailAddress( "fireforce@gmail.com");
                message.To.Add(textbox2.Text);
                message.Body = textbox5.Text;
                message.Subject = "Estimation for your request";
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;

                //attachment

                client.Credentials = new System.Net.NetworkCredential();//username and pwd of the system
                client.Send(message);
                message = null;

                MessageBox.Show("Mail has been send"); 
            }
            catch(Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {

            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM projectest");
            procost.DataSource = ds.Tables["load"];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM vehicleest WHERE vehEstID='" + sv.Text + "'");
           vehiclecost.DataSource = ds.Tables["load"];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                this.Selecttype.Items.Clear();
                this.Selecttype.Items.Add("Select Items");
                this.Selecttype.Items.Add("fItem1");
                this.Selecttype.Items.Add("fItem2");
                this.Selecttype.Items.Add("fItem3");
                this.Selecttype.Items.Add("fItem4");
                this.Selecttype.Items.Add("fItem5");
                this.Selecttype.Items.Add("fItem6");

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {

                this.Selecttype.Items.Clear();
                this.Selecttype.Items.Add("Select Items");
                this.Selecttype.Items.Add("hItem1");
                this.Selecttype.Items.Add("hItem2");
                this.Selecttype.Items.Add("hItem3");
                this.Selecttype.Items.Add("hItem4");
                this.Selecttype.Items.Add("hItem5");
                this.Selecttype.Items.Add("hItem6");

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {

                this.Selecttype.Items.Clear();
                this.Selecttype.Items.Add("Select Items");
                this.Selecttype.Items.Add("eItem1");
                this.Selecttype.Items.Add("eItem2");
                this.Selecttype.Items.Add("eItem3");
                this.Selecttype.Items.Add("eItem4");
                this.Selecttype.Items.Add("eItem5");
                this.Selecttype.Items.Add("eItem6");

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM requestforesti");
            estreqsts.DataSource = ds.Tables["load"];

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM vehicleest");
           vehiclecost.DataSource = ds.Tables["load"];

        }
    }
}

