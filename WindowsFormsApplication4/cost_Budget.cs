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

namespace WindowsFormsApplication4
{
    public partial class cost_Budget : UserControl
    {
        Database db = new Database();
        private static cost_Budget _instance;
        public static cost_Budget Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new cost_Budget();
                return _instance;
            }
        }
        public cost_Budget()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=custmandb");
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT * FROM test3", connection);
            MySqlDataReader myReader;

            try
            {
                connection.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    this.chart1.Series["Budget"].Points.AddXY(myReader.GetString("Month"), myReader.GetInt32("Budget"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                // MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; database = costmn");
                /* MySqlDataAdapter adapter = new MySqlDataAdapter*/
                DataSet ds = db.dbse("SELECT budget FROM management");
                //connection.Open();
               // DataSet ds = new DataSet();
               // adapter.Fill(ds, "management");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
               // connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {






                DataSet ds = db.dbse("SELECT Budget FROM test3 where Year='" + textBox1.Text + "'AND Month='" + comboBox1.Text + "'");


                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
                



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
