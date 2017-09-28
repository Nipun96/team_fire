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
    public partial class Employee_attendance : UserControl
    {
        private static Employee_attendance _instance;
        private object con;

        public static Employee_attendance Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Employee_attendance();
                return _instance;
            }
        }
        public Employee_attendance()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            table123.Visible = false;
            table13.Visible = true;
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM attendance WHERE cardid ='" + serach1.Text + "'");
            table13.DataSource = ds.Tables["load"];




            // string ds1 = ("SELECT cardid = '" + cardid1.Text + "', lname = '" + lname1.Text + "', address1 = '" + address11.Text + "', tel = '" + telephone1.Text + "', position = '" + position1.Text + "', dob = '" + dob1.Text + "',gender = 'M'  FROM attendance WHERE cardid ='" + serach1.Text + "'");

            //db.Dbselect(ds1);

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fname1_OnValueChanged(object sender, EventArgs e)
        {

            // Database db = new Database();
            // string ds1 = ("SELECT fname = '" + fname1.Text + "'  FROM attendance WHERE cardid ='" + serach1.Text + "'");

            //db.Dbselect(ds1);



        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            table123.Visible = true;
            table13.Visible = false;
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM emp_reg WHERE cardid ='" + serach1.Text + "'");
            table123.DataSource = ds.Tables["load"];

            /*attendanceCheck dr = new attendanceCheck();
            con.Open();
         string selectQuery = ("SELECT * FROM emp_reg WHERE cardid ='" + serach1.Text + "'");
            cmd = new MySqlCommand(selectQuery, conn);
             dr = cmd.ExecuteReader();

             if (dr.Read())
            {
                fname1.Text = dr.GetString("fname");
                lname1.Text = dr.GetString("lname");
                dob1.Text = dr.GetString("dob");
                gender1.Text = dr.GetString("gender");
                nic1.Text = dr.GetString("nic");
                position1.Text = dr.GetString("position");
                cardid1.Text = dr.GetString("cardid");


             }

             else
            {
                    serach1.Text = " ";
                  fname1.Text = " ";
                  lname1.Text = " ";
                  dob1.Text = " ";
                  gender1.Text = " ";
                    nic1.Text = " ";
                  position1.Text = " ";
                  cardid1.Text = " ";
                  MessageBox.Show("No Data for This ID", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

 }
        con.Close();
        }*/
        }

        private void table123_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = e.RowIndex;
            DataGridViewRow selectedRow = table123.Rows[r];

            fname1.Text = selectedRow.Cells[0].Value.ToString();
            lname1.Text = selectedRow.Cells[1].Value.ToString();
            dob1.Text = selectedRow.Cells[2].Value.ToString();
            gender1.Text = selectedRow.Cells[3].Value.ToString();
            nic1.Text = selectedRow.Cells[7].Value.ToString();
            position1.Text = selectedRow.Cells[9].Value.ToString();
            cardid1.Text = selectedRow.Cells[10].Value.ToString();
            address11.Text = selectedRow.Cells[4].Value.ToString();
            telephone1.Text = selectedRow.Cells[8].Value.ToString();
           // address2.Text = selectedRow.Cells[5].Value.ToString();
           // city.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void Employee_attendance_Load(object sender, EventArgs e)
        {

        }

        private void serach1_Enter(object sender, EventArgs e)
        {
            if (serach1.Text == "Search card id")
            {
                serach1.Text = "";
                serach1.ForeColor = Color.Black;
            }
        }

        private void serach1_Leave(object sender, EventArgs e)
        {
            if (serach1.Text == "")
            {
                serach1.Text = "Search card id";
                serach1.ForeColor = Color.Black;
            }
        }
    }
}



