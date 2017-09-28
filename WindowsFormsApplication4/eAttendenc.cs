using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    
    public partial class eAttendenc : System.Windows.Forms.Form
    {
        Database db = new Database();
        string x;
        public eAttendenc()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime currentTime = DateTime.Now;
            this.button6888.Text = currentTime.ToLongTimeString();
            this.button7566.Text = currentTime.ToLongDateString();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)

            //{

            //}
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }



            if (bunifuMaterialTextbox2 .Text.Length == 10 )
            {
               // MessageBox.Show("valid");

                //string test = DateTime.ParseExact(DateTime.Now.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");


                String date1 = DateTime.Now.ToString("dd-MM-yyyy");
                String time1 = DateTime.Now.ToString("h:mm:ss tt");

                Database db = new Database();
                
                

                string cd = bunifuMaterialTextbox2.Text;

                //string ddt= dt.ToString();
                String date2 = DateTime.Now.ToString("dd-MM-yyyy");
                String qur = "SELECT date FROM attendance WHERE cardid ='" + bunifuMaterialTextbox2.Text + "' and  date = '"+ date2 +"' ";

                String a = db.dbgett(qur);

               // label5.Text = a.Substring(0,10);
               // label6.Text = date1;

                if (String.Compare(date1, a) == 0)
                {
                    //String date2 = DateTime.Now.ToString("dd-MM-yyyy");
                    
                    String qur1 = ("SELECT leave_time FROM attendance WHERE cardid ='" + bunifuMaterialTextbox2.Text + "' and  date = '"+ date2 +"' " );
                    String b = db.dbgett(qur1);
                   
                    label5.Text = b;
                    
                    
                    if(String.Compare(b,"00:00:00") == 0)
                    {



                        String time2 = DateTime.Now.ToString("h:mm:ss tt");
                        string qu = "Update attendance SET leave_time = '" + time2 + "' WHERE cardid = '" + cd + "'";
                        db.Dbupdate(qu);
                        String qur2 = "SELECT comming_time FROM attendance WHERE cardid ='" + bunifuMaterialTextbox2.Text + "'" ;
                        String d = db.dbgett(qur2);
                        /* DateTime dateTime3 = DateTime.ParseExact(d, "HH:mm:ss",
                                       CultureInfo.InvariantCulture);

                         //var result = Convert.ToDateTime(time);

                         String t = "05:00:00";
                             DateTime dateTime = DateTime.ParseExact(time2, "HH:mm:ss",
                                         CultureInfo.InvariantCulture);
                             DateTime dateTime1 = DateTime.ParseExact(t, "HH:mm:ss",
                                         CultureInfo.InvariantCulture);*/
                        var dateTime = Convert.ToDateTime(time2);
                        String t = "17:00:00";
                        var dateTime1 = Convert.ToDateTime(t);
                        var dateTime3 = Convert.ToDateTime(d);

                        if (dateTime < dateTime1)
                        {



                            TimeSpan work_hour = dateTime.Subtract(dateTime1);
                            //string work_hour = (dateTime1.Subtract(dateTime).TotalMinutes).ToString();
                            

                            label6.Text = work_hour.ToString();
                            string qu2 = "Update attendance SET work_hour = '" + work_hour + "' where cardid= '" + cd + "'";
                            db.Dbupdate(qu2);
                        }
                        else
                        {

                            TimeSpan work_hour1 = dateTime1.Subtract(dateTime3);
                            TimeSpan ot_hour = dateTime.Subtract(dateTime1);
                            //string work_hour1 = (dateTime3.Subtract(dateTime1).TotalMinutes).ToString();
                           // string ot_hour = (dateTime1.Subtract(dateTime).TotalMinutes).ToString();

                            string qu3 = "Update attendance SET work_time = '" + work_hour1 + "', ot_time = '" + ot_hour + "'   where cardid = '" + cd + "'";
                            db.Dbupdate(qu3);
                        }
                        





                        

                    }
                    else
                    {
                        MessageBox.Show("YOU ALREADY LEAVE");
                    }
                }
                else
                {
                    //if (String.Compare(time1, "17:00:00") == 0)
                    //{
                        string qu = "insert into attendance (cardid,date,comming_time) values('" + bunifuMaterialTextbox2.Text + "','" + date1 + "' , '" + time1 + "')";
                        db.DBhand(qu);
                    //}
                    //else
                    //{
                      //  MessageBox.Show("You are not allowed to enter");
                    //}
                }
                DataSet ds = db.dbse("SELECT * FROM attendance WHERE date ='" + date1 + "'");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
                //  Database db = new Database();

                /*  string qu = "insert into attendance (cardid,date,comming_time) values('" + bunifuMaterialTextbox2.Text + "','" + date1+ "' , '" + time1 + "')";
                   db.DBhand(qu);*/


                bunifuMaterialTextbox2.Text = "";

                

            }

            if (bunifuMaterialTextbox2.Text.Length >11)
            {
               
                e.Handled = false;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[r];

            x = selectedRow.Cells[1].Value.ToString();
        }
    }
}
