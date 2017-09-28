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

    
    public partial class esalary : UserControl
    {

        Database db = new Database();
        
        double salary1;

        private static esalary _instance;
        public static esalary Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new esalary();
                return _instance;
            }
        }
        public esalary()
        {
            InitializeComponent();
            allownces.Text = "0";
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ename.Text = "";
            empid.Text = "";
            //rph.Text = "";
            //rpoh.Text = "";
            allownces.Text = "";
           // deduction.Text = "";
           // basicsalary.Text = "";
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

/*
         
            Database db = new Database();
            DataSet ds = db.dbse("SELECT comming_time,leave_time FROM attendance WHERE empid ='" + empid.Text + "'");
            DataSet ds1 = db.dbse("SELECT rate_per_hour,rate_per_ot_hour,basic_salary FROM attendance WHERE empid ='" + empid.Text + "'");
            DataSet ds2 = db.dbse("SELECT amount FROM loan WHERE empid ='" + empid.Text + "'");
            if()


    */



        }

        private void basicsalary_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Database db = new Database();
            /*  Database db = new Database();
              DataSet ds = db.dbse("SELECT comming_time,leave_time FROM attendance WHERE empid ='" + empid.Text + "'");
              DataSet ds1 = db.dbse("SELECT rate_per_hour,rate_per_ot_hour,basic_salary FROM attendance WHERE empid ='" + empid.Text + "'");
              DataSet ds2 = db.dbse("SELECT amount FROM loan WHERE empid ='" + empid.Text + "'");
              if ()*/
            try
            {
                //string a = "1111";
                String qur1 = "SELECT basic_salary FROM emp_reg WHERE empid =" + empid.Text + "  ";
               // string qur1 = "SELECT * FROM emp_reg";
              //  +empid.Text +

                String qur2 = ("SELECT rate_per_hour FROM emp_reg WHERE empid ='" + empid.Text + "'  ");
                String b = db.dbgett(qur1);
                //string b = "12";

                String b1 = db.dbgett(qur2);

               // int rate_per_hour = Convert.ToInt32(b1);

                //int basic_salary = Convert.ToInt32(b);
                 var rate_per_hour = Int32.Parse(b1);
                var basic_salary = Int32.Parse(b);



                String qur3 = ("SELECT rate_per_ot_hour FROM emp_reg WHERE empid ='" + empid.Text + "'  ");
                String b2 = db.dbgett(qur3);
                                 String qur4 = ("SELECT amount FROM loan WHERE empid ='" + empid.Text + "'  ");
                String b3 =  db.dbgett(qur4);
               // int rate_per_ot_hour = Convert.ToInt32(b2);
               // int amount = Convert.ToInt32(b3);
                var rate_per_ot_hour = Int32.Parse(b2);
                var amount = Int32.Parse(b3);


                String date = bunifuDatepicker1.Value.Date.ToString("YYYY-MM-DD");
                String date2 = bunifuDatepicker2.Value.Date.ToString("YYYY-MM-DD");

                  String QU = (" SELECT SUM(work_time) FROM attendance WHERE date BETWEEN '" + date + "' AND '" + date2 + "'  AND empid = '" + empid.Text + "' ");

                String b4 = db.dbgett(QU);
                                    String QU1 = (" SELECT SUM(ot_time) FROM attendance WHERE date BETWEEN '" + date + "' AND '" + date2 + "' AND empid = '" + empid.Text + "' ");

                String b5 =  db.dbgett(QU1);
                // int total_work_time = Convert.ToInt32(b4);
                // int total_ot_time = Convert.ToInt32(b5);
                var total_work_time = Int32.Parse(b2);
                var total_ot_time = Int32.Parse(b2);

                int allowences = Convert.ToInt32(allownces.Text);

                if (allowences >= 0)
                {
                    var total_salary = (total_work_time * rate_per_hour) + (total_ot_time * rate_per_ot_hour) + basic_salary - amount+ allowences;
                    label4.Text = "Total Salary is " + Convert.ToString(total_salary);

                }
                else
                {
                    MessageBox.Show("invalid allownces");
                }

                // var total_salary = (total_work_time * rate_per_hour) + (total_ot_time * rate_per_ot_hour) + basic_salary - amount;



               // label4.Text = "Total Salary is "+Convert.ToString(total_salary);
            }
            catch (Exception ee)
            {
                MessageBox.Show("error"+ee);
            }




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM salary WHERE empid ='" + empid.Text + "'");
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }

        private void empid_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void empid_Enter(object sender, EventArgs e)
        {
            if (empid.Text == "Enter employee id")
            {
                empid.Text = "";
                empid.ForeColor = Color.Black;
            }
        }

        private void empid_Leave(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM emp_reg WHERE empid ='" + empid.Text + "'");
            table1234.DataSource = ds.Tables["load"];


        }
    }
}
