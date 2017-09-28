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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
                label3.Text = "Requests";//change Header Name

               
            }
                if (!panel5.Controls.Contains(requests.Instance))
            {
                panel5.Controls.Add(requests.Instance);
                requests.Instance.Dock = DockStyle.Fill;
                requests.Instance.BringToFront();
            }
            else
                requests.Instance.BringToFront();

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
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
                label3.Text = "Blue Prints";//change Header Name


            }
            if (!panel5.Controls.Contains(cust_Blueprints.Instance))
            {
                panel5.Controls.Add(cust_Blueprints.Instance);
                cust_Blueprints.Instance.Dock = DockStyle.Fill;
                cust_Blueprints.Instance.BringToFront();
            }
            else
                cust_Blueprints.Instance.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
                label3.Text = "Payments";//change Header Name


            }
            if (!panel5.Controls.Contains(cust_payment.Instance))
            {
                panel5.Controls.Add(cust_payment.Instance);
                cust_payment.Instance.Dock = DockStyle.Fill;
                cust_payment.Instance.BringToFront();
            }
            else
                cust_payment.Instance.BringToFront();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
                label3.Text = "Estimations";//change Header Name


            }
            if (!panel5.Controls.Contains(cust_estimation.Instance))
            {
                panel5.Controls.Add(cust_estimation.Instance);
                cust_estimation.Instance.Dock = DockStyle.Fill;
                cust_estimation.Instance.BringToFront();
            }
            else
                cust_estimation.Instance.BringToFront();

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
            indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel4.Visible = false;


        }
       
    }

}
