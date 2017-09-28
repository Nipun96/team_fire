using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class jcCost : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database=custmandb");
        MySqlCommand command;
        MySqlDataReader mdr;
        String str;
        public jcCost()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                String selecq = "SELECT * FROM chcost ";
                command = new MySqlCommand(selecq, con);
                mdr = command.ExecuteReader();

                if (mdr.Read())
                {                    
                    textBox1.Text = mdr.GetString("foodCost");
                    textBox2.Text = mdr.GetString("costPerKm");
                    textBox3.Text = mdr.GetString("rentalPerDay");


                    con.Close();
                }
                else
                {
                    MessageBox.Show("Your entered worker's ID is incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Do you want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Can't leave empty","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    con.Open();
                    String selecq = "UPDATE chcost  SET foodCost='"+ float.Parse(textBox1.Text)+ "', costPerKm='"+float.Parse(textBox2.Text)+ "', rentalPerDay='"+float.Parse(textBox3.Text)+"'";
                    command = new MySqlCommand(selecq, con);
                    mdr = command.ExecuteReader();
                    MessageBox.Show("SuccesFull Updated");
                    this.Dispose();
                    con.Close();

                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
