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
    public partial class dailyexpenses : UserControl
    {
        Database db = new Database();
        private static dailyexpenses _instance;
        public static dailyexpenses Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new dailyexpenses();
                return _instance;
            }
        }
        public dailyexpenses()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                //MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; database = costmn");
                /* MySqlDataAdapter adapter = new MySqlDataAdapter*/
                // DataSet ds = db.dbse("SELECT sum(expense) FROM costmn.management");
                DataSet ds = db.dbse("SELECT sum(Expense) as Expense FROM test2 where Department='" + bunifuDropdown2.selectedValue + "' AND (Date<='" + dateTimePicker1.Text + "'AND Date>='" + dateTimePicker2.Text + "')");
                //connection.Open();
                // DataSet ds = new DataSet();
                // adapter.Fill(ds, "management");
                bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
               // connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                // MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; database = costmn");
                /* MySqlDataAdapter adapter = new MySqlDataAdapter*/
                DataSet ds = db.dbse("SELECT Expense,Department,Date FROM test2 where Department='"+bunifuDropdown1.selectedValue+"' AND Date='"+dateTimePicker1.Value.Date.ToString("yyyy-MM-dd")+"'");
                //connection.Open();
                //DataSet ds = new DataSet();
               // adapter.Fill(ds, "management");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
                //connection.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
