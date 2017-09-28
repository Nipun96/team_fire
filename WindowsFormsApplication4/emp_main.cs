using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class emp_main : System.Windows.Forms.Form
    {
        public emp_main()
        {
            InitializeComponent();

            timer2.Start(); //for display current date and time 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
               
            }
                if (!panel5.Controls.Contains(employee_manage.Instance))
            {
                panel5.Controls.Add(employee_manage.Instance);
                employee_manage.Instance.Dock = DockStyle.Fill;
                employee_manage.Instance.BringToFront();
            }
            else
                employee_manage.Instance.BringToFront();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
        int mousex = 0, mousey = 0;
        bool mousedown;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mousedown)
            {
                mousex = MousePosition.X - 1000;
                mousey = MousePosition.Y - 40;

                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
            if(this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;

            }
            if (!panel5.Controls.Contains(Employee_attendance.Instance))
            {
                panel5.Controls.Add(Employee_attendance.Instance);
                Employee_attendance.Instance.Dock = DockStyle.Fill;
                Employee_attendance.Instance.BringToFront();
            }
            else
                Employee_attendance.Instance.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;

            }
            if (!panel5.Controls.Contains(employee_details.Instance))
            {
                panel5.Controls.Add(employee_details.Instance);
                employee_details.Instance.Dock = DockStyle.Fill;
                employee_details.Instance.BringToFront();
            }
            else
                employee_details.Instance.BringToFront();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;

            }
            if (!panel5.Controls.Contains(esalary.Instance))
            {
                panel5.Controls.Add(esalary.Instance);
                esalary.Instance.Dock = DockStyle.Fill;
                esalary.Instance.BringToFront();
            }
            else
                esalary.Instance.BringToFront();

        }


        Timer timer1 = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
         
        
    }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;

            }
            if (!panel5.Controls.Contains(reports.Instance))
            {
                panel5.Controls.Add(reports.Instance);
                reports.Instance.Dock = DockStyle.Fill;
                reports.Instance.BringToFront();
            }
            else
                reports.Instance.BringToFront();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;

            }
            if (!panel5.Controls.Contains(ereport.Instance))
            {
                panel5.Controls.Add(ereport.Instance);
                ereport.Instance.Dock = DockStyle.Fill;
                ereport.Instance.BringToFront();
            }
            else
                ereport.Instance.BringToFront();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            this.button6.Text = currentTime.ToLongTimeString();
            this.button7.Text = currentTime.ToLongDateString();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;

            }
            if (!panel5.Controls.Contains(eloan.Instance))
            {
                panel5.Controls.Add(eloan.Instance);
                eloan.Instance.Dock = DockStyle.Fill;
                eloan.Instance.BringToFront();
            }
            else
                eloan.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel4.Visible = false;


        }
       
    }

}
