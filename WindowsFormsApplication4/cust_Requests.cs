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
using System.Text.RegularExpressions;


namespace WindowsFormsApplication4
{


    public partial class requests : UserControl
    {
        //  MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        // int currentRow;
        //   String id;

        private static requests _instance;
        Database db = new Database();
        public static requests Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new requests();
                return _instance;
            }
        }
        public requests()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void requests_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                String qry = "INSERT INTO custmandb.requestforesti(fullname,serviceType) VALUES('" + textbox1.Text + "', '" + comboBox1.Text + "') "; //change table name and DB name
                db.DBhand(qry);
                MessageBox.Show("Request for estimation has been placed");

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {


                String qr = "INSERT INTO custmandb.jobrqst(fullname,adl1,adl2,city,serviceType) VALUES('" + textbox1.Text + "','" + textbox4.Text + "','" + textbox5.Text + "','" + textbox6.Text + "','" + comboBox1.Text + "') ";//change DB and table name //error in duplicate??
                db.DBhand(qr);
                MessageBox.Show("A request for job has been placed..!");

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (textbox1.Text != "" && textbox2.Text != "" && textbox3.Text != "" && textbox4.Text != "" && textbox5.Text != "" && textbox6.Text != "" && textbox7.Text != "")
            {

                try
                {


                    String q = "INSERT INTO custmandb.newcustrqst(fullname,email,contactNo,adl1,adl2,city,company,serviceType) VALUES('" + textbox1.Text + "', '" + textbox2.Text + "','" + textbox3.Text + "','" + textbox4.Text + "','" + textbox5.Text + "','" + textbox6.Text + "','" + textbox7.Text + "','" + comboBox1.Text + "') ";
                    db.DBhand(q);

                    DataSet ds = db.dbse("SELECT * FROM newcustrqst");

                    DataTable table = new DataTable();

                    BindingSource bsource = new BindingSource();

                    requestDetails.DataSource = ds.Tables["load"];
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
                //To be added table load

                //String insertQuery = "INSERT INTO custmandb.newcustrqst(fullname,email,contactNo,adl1,adl2,city,company,serviceType) VALUES('" + textbox1.Text + "', '" + textbox2.Text + "','" + textbox3.Text + "','" + textbox4.Text + "','" + textbox5.Text + "','" + textbox6.Text + "','" + textbox7.Text + "','" + comboBox1.Text + "') "; //change dtabase and table name 

            }
            else
            {
                MessageBox.Show("Cannot have empty text boxes");
            }
        

    }

    private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Database db = new Database();

        String qu = "DELETE  FROM newcustrqst WHERE custID= '" + s1.Text + "'";
        db.Dbdelet(qu);

        MessageBox.Show("The request was removed successfully");
    }

    private void requestDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        int r = e.RowIndex;
        DataGridViewRow selectRow = requestDetails.Rows[r];
        //  id = selectRow.Cells[1].Value.ToString();


        s1.Text = selectRow.Cells[1].Value.ToString();

    }

        private void button6_Click(object sender, EventArgs e)
        {
            textbox1.Clear();
            textbox2.Clear();
            textbox3.Clear();
            textbox4.Clear();
            textbox5.Clear();
            textbox6.Clear();
            textbox7.Clear();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM newcustrqst WHERE fullname='" + s1.Text + "'");
            requestDetails.DataSource = ds.Tables["load"];
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM newcustrqst");
            requestDetails.DataSource = ds.Tables["load"];
        }

        private void s1_Click(object sender, EventArgs e)
        {

        }

        private void textbox1_Click(object sender, EventArgs e)
        {/*
            int maxCharacters = 30;
            String err = "";
            String contents = this.textbox1.Text;

            if(contents.Length==0)
            {
                err = "This area canno't be empty";
                e.Cancel = true;
            }

            else if(contents.Length>30)
            {
                err = "Name cannot contain more than " + maxCharacters + " characters";
                e.Cancel
            }*/
        }

        private void textbox3_Click(object sender, EventArgs e)
        {
           
        }

        private void textbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar !='.') && (e.KeyChar !=8))
            {
                e.Handled = true;

            }
            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.')>-1))
            {
                e.Handled = true;
            }
            if(textbox3.Text.Length==10)
            {
                e.Handled = true;
            }
        }

        private void textbox1_Enter(object sender, EventArgs e)
        {
            if(textbox1.Text == "Enter full name")
            {
                textbox1.Text = "";
                textbox1.ForeColor = Color.Black;
            }

        }

        private void textbox2_Click(object sender, EventArgs e)
        {
            // Regex EmailRegex = new Regex(@"^({\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            
        }

        private void textbox2_Enter(object sender, EventArgs e)
        {
            if (textbox2.Text == "Enter email")
            {
                textbox2.Text = "";
                textbox2.ForeColor = Color.Black;
            }

        }

        private void textbox3_Enter(object sender, EventArgs e)
        {
            if (textbox3.Text == "Enter contact number")
           
                textbox3.Text = "";
                textbox3.ForeColor = Color.Black;
            }

        private void textbox4_Enter(object sender, EventArgs e)
        {
            if (textbox4.Text == "Enter address line 1")
            {
                textbox4.Text = "";
                textbox4.ForeColor = Color.Black;
            }

        }

        private void textbox5_Enter(object sender, EventArgs e)
        {
            if (textbox5.Text == "Enter address line 2")
            {
                textbox5.Text = "";
                textbox5.ForeColor = Color.Black;
            }
        }

        private void textbox6_Enter(object sender, EventArgs e)
        {
            if (textbox6.Text == "Enter city")
            {
                textbox6.Text = "";
                textbox6.ForeColor = Color.Black;
            }
        }

        private void textbox7_Enter(object sender, EventArgs e)
        {
            if (textbox7.Text == "Enter Company name")
            {
                textbox7.Text = "";
                textbox7.ForeColor = Color.Black;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Select service type")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void textbox1_Leave(object sender, EventArgs e)
        {
            if(textbox1.Text=="")
            {
                textbox1.Text = "Enter full name";
                textbox1.ForeColor = Color.DimGray;
            }
        }

        private void textbox2_Leave(object sender, EventArgs e)
        {
            if (textbox2.Text == "")
            {
                textbox2.Text = "Enter email";
                textbox2.ForeColor = Color.DimGray;
            }

            try
            {
                if (!this.textbox2.Text.Contains('@') || !this.textbox2.Text.Contains('.'))
                {
                    MessageBox.Show("Enter a valid email address");
                }
            }
            catch (Exception eee)
            {
                throw eee;
            }
        }

        private void textbox3_Leave(object sender, EventArgs e)
        {
            if (textbox3.Text == "")
            {
                textbox3.Text = "Enter contact number";
                textbox3.ForeColor = Color.DimGray;
            }
        }

        private void textbox4_Leave(object sender, EventArgs e)
        {
            if (textbox4.Text == "")
            {
                textbox4.Text = "Enter address line 1";
                textbox4.ForeColor = Color.DimGray;
            }
        }

        private void textbox5_Leave(object sender, EventArgs e)
        {
            if (textbox5.Text == "")
            {
                textbox5.Text = "Enter address line 2";
                textbox5.ForeColor = Color.DimGray;
            }
        }

        private void textbox6_Leave(object sender, EventArgs e)
        {

            if (textbox6.Text == "")
            {
                textbox6.Text = "Enter city";
                textbox6.ForeColor = Color.DimGray;
            }
        }

        private void textbox7_Leave(object sender, EventArgs e)
        {
            if (textbox7.Text == "")
            {
                textbox7.Text = "Enter Company name";
                textbox7.ForeColor = Color.DimGray;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Select service type";
                comboBox1.ForeColor = Color.DimGray;
            }
        }

        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
    
}
