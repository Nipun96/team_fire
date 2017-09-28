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
    public partial class vehicle_main : Form
    {
        public vehicle_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
                label3.Text = "Status";
               
            }
                if (!panel5.Controls.Contains(vstatus.Instance))
            {
                panel5.Controls.Add(vstatus.Instance);
                vstatus.Instance.Dock = DockStyle.Fill;
                vstatus.Instance.BringToFront();
            }
            else
                vstatus.Instance.BringToFront();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            main fm3 = new main();
            fm3.Visible = true;

            vehicle_main fm1 = new vehicle_main();
            fm1.Visible = false;
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
                label3.Text = "Income";
            }
            if (!panel5.Controls.Contains(cost.Instance))
            {
                panel5.Controls.Add(cost.Instance);
                cost.Instance.Dock = DockStyle.Fill;
                cost.Instance.BringToFront();
            }
            else
                cost.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
                label3.Text = "Reserve";
            }
            if (!panel5.Controls.Contains(vreserve.Instance))
            {
                panel5.Controls.Add(vreserve.Instance);
                vreserve.Instance.Dock = DockStyle.Fill;
                vreserve.Instance.BringToFront();
            }
            else
                vreserve.Instance.BringToFront();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
                label3.Text = "Register";
            }
            if (!panel5.Controls.Contains(vregister.Instance))
            {
                panel5.Controls.Add(vregister.Instance);
                vregister.Instance.Dock = DockStyle.Fill;
                vregister.Instance.BringToFront();
            }
            else
                vregister.Instance.BringToFront();

        }


        Timer timer1 = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = DateTime.Now.ToString("yyy-MM-dd");
            bunifuCustomLabel2.Text = System.DateTime.Now.ToString("hh:mm:ss");
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(this.timer_tick);
            timer.Interval = 1000;
            timer.Enabled = true;

        }

        private void timer_tick(object sender, EventArgs e)
        {
            bunifuCustomLabel2.Text = System.DateTime.Now.ToString("hh:mm:ss");
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
                label3.Text = "Service Repair";
            }
            if (!panel5.Controls.Contains(vsr.Instance))
            {
                panel5.Controls.Add(vsr.Instance);
                vsr.Instance.Dock = DockStyle.Fill;
                vsr.Instance.BringToFront();
            }
            else
                vsr.Instance.BringToFront();
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
                label3.Text = "Reports";
            }
            if (!panel5.Controls.Contains(vreport.Instance))
            {
                panel5.Controls.Add(vreport.Instance);
                vreport.Instance.Dock = DockStyle.Fill;
                vreport.Instance.BringToFront();
            }
            else
                vreport.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel4.Visible = false;


        }
       
    }

}
