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
    public partial class cost_incomeprofit : UserControl
    {
        Database db = new Database();

        private static cost_incomeprofit _instance;
        public static cost_incomeprofit Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new cost_incomeprofit();
                return _instance;
            }
        }
        public cost_incomeprofit()
        {
            InitializeComponent();
        }
        public String getMonth(String a)
        {
            if (a == "January")
            {
                return "1";
            }
            else if (a == "February")
            {
                return "2";
            }
            else if (a == "March")
            {
                return "3";
            }
            else if (a == "April")
            {
                return "4";
            }
            else if (a == "May")
            {
                return "5";
            }
            else if (a == "June")
            {
                return "6";
            }
            else if (a == "July")
            {
                return "7";
            }
            else if (a == "August")
            {
                return "8";
            }
            else if (a == "September")
            {
                return "9";
            }
            else if (a == "October")
            {
                return "10";
            }
            else if (a == "November")
            {
                return "11";
            }
            else if (a == "December")
            {
                return "12";
            }
            else
            {
                return "a";
            }
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {




                // MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; database = costmn");
                /*  MySqlDataAdapter adapter = new MySqlDataAdapter*/
                //DataSet ds = db.dbse("SELECT sum(income) FROM costmn.management where Date='"+dt+"'");
                // DataSet ds = db.dbse("SELECT sum(income) FROM costmn.management where Department=Project");

                DataSet ds = db.dbse("SELECT sum(income) FROM test1 where Date<='" + dateTimePicker1.Text + "'AND Date>='" + dateTimePicker2.Text + "'");
                
                // connection.Open();
                // DataSet ds = new DataSet();
                // adapter.Fill(ds, "management");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
                //connection.Close();



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               /* String dm = getMonth(comboBox2.Text);
                String s = comboBox1.SelectedItem.ToString();

                if ("10" != getMonth(comboBox2.Text) && "11" != getMonth(comboBox2.Text) && "12" != getMonth(comboBox2.Text))
                {
                    dm = "0" + getMonth(comboBox2.Text);
                }

                String dt = comboBox1.Text + "-" + dm;*/




                // MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; database = costmn");
                /*MySqlDataAdapter adapter = new MySqlDataAdapter*/
                //  DataSet ds = db.dbse("SELECT profit FROM costmn.management");
                // DataSet ds = db.dbse("SELECT sum(profit) FROM costmn.management where month(Date)");
                // DataSet ds = db.dbse("SELECT * FROM costmn.test1 where Date = '" + dt + "'");
                DataSet ds = db.dbse("SELECT Profit FROM test3 where Year='" + textBox1.Text + "'AND Month='"+comboBox1.Text+"'");
                //connection.Open();
                // DataSet ds = new DataSet();
                //  adapter.Fill(ds, "management");
                bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
               // connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=custmandb");
            MySqlCommand cmdDataBase =new MySqlCommand("SELECT * FROM test3",connection);
            MySqlDataReader myReader;

            try
            {
                connection.Open();
                myReader = cmdDataBase.ExecuteReader();
                while(myReader.Read())
                {
                    this.chart1.Series["Profit"].Points.AddXY(myReader.GetString("Month"), myReader.GetInt32("Profit"));
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
