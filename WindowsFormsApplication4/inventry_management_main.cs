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
    public partial class inventry_management_main : Form
    {
        public inventry_management_main()
        {
            InitializeComponent();

            timer2.Start(); //for display current date and time
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
                label3.Text = "Edit Text";//change Header Name

               
            }
                if (!panel5.Controls.Contains(inventry_status.Instance))
            {
                panel5.Controls.Add(inventry_status.Instance);
                inventry_status.Instance.Dock = DockStyle.Fill;
                inventry_status.Instance.BringToFront();
            }
            else
                inventry_status.Instance.BringToFront();

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
            //if (MessageBox.Show("Do you want to Log out?", "log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            // {
            this.Close();
           // }
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

        private void button4_Click(object sender, EventArgs e) //storage button

        {
           
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
                label3.Text = "Storage";//change Header Name 

            }
            if (!panel5.Controls.Contains(inventry_storage.Instance))
            {
                panel5.Controls.Add(inventry_storage.Instance);
                inventry_storage.Instance.Dock = DockStyle.Fill;
                inventry_storage.Instance.BringToFront();
            }
            else
                inventry_storage.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)//order details button
        {
           
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
                label3.Text = "Order Details";//change Header Name
            }
            if (!panel5.Controls.Contains(inventry_orderdetails.Instance))
            {
                panel5.Controls.Add(inventry_orderdetails.Instance);
                inventry_orderdetails.Instance.Dock = DockStyle.Fill;
                inventry_orderdetails.Instance.BringToFront();
            }
            else
            { inventry_orderdetails.Instance.BringToFront(); }

           

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
           
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
                label3.Text = "Dashboard";

            }
                if (!panel5.Controls.Contains(inventry_dashboard.Instance))
            {
                panel5.Controls.Add(inventry_dashboard.Instance);
                inventry_dashboard.Instance.Dock = DockStyle.Fill;
                inventry_dashboard.Instance.BringToFront();
            }
            else
                inventry_dashboard.Instance.BringToFront();

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

        private void button5_Click(object sender, EventArgs e) // add items button
        {
           
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
                label3.Text = "Add Items";//change Header Name
            }
            if (!panel5.Controls.Contains(inventry_update_stocks.Instance))
            {
                panel5.Controls.Add(inventry_update_stocks.Instance);
                inventry_update_stocks.Instance.Dock = DockStyle.Fill;
                inventry_update_stocks.Instance.BringToFront();
            }
            else
                inventry_update_stocks.Instance.BringToFront();
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
                label3.Text = "Add Items";//change Header Name
            }
            if (!panel5.Controls.Contains(inventry_rejectitems.Instance))
            {
                panel5.Controls.Add(inventry_rejectitems.Instance);
                inventry_rejectitems.Instance.Dock = DockStyle.Fill;
                inventry_rejectitems.Instance.BringToFront();
            }
            else
                inventry_rejectitems.Instance.BringToFront();

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;// estimation button
                label3.Text = "Reports";//change Header Name
            }
            if (!panel5.Controls.Contains(inventry_report.Instance))
            {
                panel5.Controls.Add(inventry_report.Instance);
                inventry_report.Instance.Dock = DockStyle.Fill;
                inventry_report.Instance.BringToFront();
            }
            else
                inventry_report.Instance.BringToFront();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            this.textBox1.Text = currentTime.ToLongTimeString();
            this.textBox2.Text = currentTime.ToLongDateString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void forwardButton_Click(object sender, EventArgs e)
        {

           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            {
               
                label3.Text = "Order Details";//change Header Name
            }
            if (!panel5.Controls.Contains(inventry_orderdetails.Instance))
            {
                panel5.Controls.Add(inventry_orderdetails.Instance);
                inventry_orderdetails.Instance.Dock = DockStyle.Fill;
                inventry_orderdetails.Instance.BringToFront();
            }
            else
                inventry_orderdetails.Instance.BringToFront();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            if (!panel5.Controls.Contains(inventry_orderdetails.Instance))
            {
                panel5.Controls.Add(inventry_orderdetails.Instance);
                inventry_orderdetails.Instance.Dock = DockStyle.Fill;
                inventry_orderdetails.Instance.BringToFront();
            }
            else
                inventry_orderdetails.Instance.BringToFront();
        }

        private void forwardButton_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!panel5.Controls.Contains(Dispatch_Orders.Instance))
            {
                panel5.Controls.Add(Dispatch_Orders.Instance);
                Dispatch_Orders.Instance.Dock = DockStyle.Fill;
                Dispatch_Orders.Instance.BringToFront();
            }
            else
                Dispatch_Orders.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel4.Visible = false;


        }
       
    }

}
