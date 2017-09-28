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
    public partial class supplier_main : Form
    {


        public supplier_main()
        {
            InitializeComponent();
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
              //  label3.Text = "Edit Text";//change Header Name

               
            }
                if (!panel5.Controls.Contains(suplier.Instance))
            {
                panel5.Controls.Add(suplier.Instance);
                suplier.Instance.Dock = DockStyle.Fill;
                suplier.Instance.BringToFront();
            }
            else
                suplier.Instance.BringToFront();

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
            indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;

            if (!panel5.Controls.Contains(sup_report.Instance))
            {
                panel5.Controls.Add(sup_report.Instance);
                sup_report.Instance.Dock = DockStyle.Fill;
                sup_report.Instance.BringToFront();
            }
            else
                sup_report.Instance.BringToFront();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;

            if (!panel5.Controls.Contains(sup_order.Instance))
            {
                panel5.Controls.Add(sup_order.Instance);
                sup_order.Instance.Dock = DockStyle.Fill;
                sup_order.Instance.BringToFront();
            }
            else
                sup_order.Instance.BringToFront();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
               
            }
                if (!panel5.Controls.Contains(sup_ratings.Instance))
            {
                panel5.Controls.Add(sup_ratings.Instance);
                sup_ratings.Instance.Dock = DockStyle.Fill;
                sup_ratings.Instance.BringToFront();
            }
            else
                sup_ratings.Instance.BringToFront();

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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (!panel5.Controls.Contains(sup_notify.Instance))
            {
                panel5.Controls.Add(sup_notify.Instance);
                sup_notify.Instance.Dock = DockStyle.Fill;
                sup_notify.Instance.BringToFront();
            }
            else
                sup_notify.Instance.BringToFront();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(!panel5.Controls.Contains(suplier.Instance))
            {
                panel5.Controls.Add(suplier.Instance);
                suplier.Instance.Dock = DockStyle.Fill;
                suplier.Instance.BringToFront();
            }
            else  
            
                suplier.Instance.BringToFront();
                sup_custom.Instance.Visible = false;
                sup_View.Instance.Visible = false;

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel4.Visible = false;


        }
       
    }

}
