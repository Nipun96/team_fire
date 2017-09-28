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
    public partial class cost_Pettycash : UserControl
    {
        Database db = new Database();
       // MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database=costmn");
        
        private static cost_Pettycash _instance;
        public static cost_Pettycash Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new cost_Pettycash();
                return _instance;
            }
        }
        public cost_Pettycash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               // DataTable dt = new DataTable();
              //  Database db = new Database();
               // con.Open();

              //  MySqlCommand cmd = con.CreateCommand();
              //  cmd.CommandType = CommandType.Text;
               /* cmd.CommandText */ String qu = "INSERT INTO Pettycash2(Amount,Year,Month,Department) VALUES('" + textBox1.Text + "','" +textBox2.Text +"','"+comboBox1.Text+"','"+bunifuDropdown1.selectedValue+"')";
                 db.DBhand(qu);
                
                //cmd.ExecuteNonQuery();
               // con.Close();
                //MessageBox.Show("Pettycash succesfully allocated");
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

               // MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; database = costmn");
               /* MySqlDataAdapter adapter = new MySqlDataAdapter */ DataSet ds=db.dbse("SELECT sum(amount) as total FROM pettycash2");
               // connection.Open();
               // DataSet ds = new DataSet();
               // adapter.Fill(ds, "pettycash");
               bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
                //connection.Close();



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

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String qu = "update pettycash2 SET Amount='" + textBox1.Text + "',Year='" + textBox2.Text + "',Month='"+comboBox1.Text+"',Department='"+bunifuDropdown1.selectedValue+"')";
            db.Dbupdate(qu);

            DataSet ds = db.dbse("Select * from pettycash2");
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid2.Rows[r];

            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            //dateTimePicker1.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet ds = db.dbse("SELECT Amount FROM pettycash2 where Year='"+textBox3.Text+"' AND Month='"+comboBox1.Text+"'");
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
