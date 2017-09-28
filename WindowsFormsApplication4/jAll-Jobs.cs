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
    public partial class status : UserControl
    {
        MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database=custmandb");
        MySqlCommand command;
        MySqlDataReader mdr;
        String str;
        private static status _instance;
        public static status Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new status();
                return _instance;
            }
        }
    public status()
    {
        InitializeComponent();
    }

        private void status_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void status_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
                {
                    command = new MySqlCommand();
                    command.Connection = con;
                    command.CommandText = "select * from assignjobs";
                    con.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
                finally
                {
                    con.Close();
                }
        }
    }

}

