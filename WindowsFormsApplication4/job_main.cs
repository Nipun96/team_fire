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
    public partial class job_main : Form
    {
        public job_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
                label3.Text = "All Jobs";//change Header Name

               
            }
                if (!panel5.Controls.Contains(status.Instance))
            {
                panel5.Controls.Add(status.Instance);
                status.Instance.Dock = DockStyle.Fill;
                status.Instance.BringToFront();
            }
            else
                status.Instance.BringToFront();

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
                label3.Text = "Assign Workers";//change Header Name
            }
            if (!panel5.Controls.Contains(jassign.Instance))
            {
                panel5.Controls.Add(jassign.Instance);
                jassign.Instance.Dock = DockStyle.Fill;
                jassign.Instance.BringToFront();
            }
            else
                jassign.Instance.BringToFront();

            MessageBox.Show("Please Press Refresh first.!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
                label3.Text = "Worker's Details";//change Header Name


            }
            if (!panel5.Controls.Contains(worker_sdetails.Instance))
            {
                panel5.Controls.Add(worker_sdetails.Instance);
                worker_sdetails.Instance.Dock = DockStyle.Fill;
                worker_sdetails.Instance.BringToFront();
            }
            else
                worker_sdetails.Instance.BringToFront();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
                label3.Text = "New Jobs";//change Header Name


            }
            if (!panel5.Controls.Contains(jnewjobs.Instance))
            {
                panel5.Controls.Add(jnewjobs.Instance);
                jnewjobs.Instance.Dock = DockStyle.Fill;
                jnewjobs.Instance.BringToFront();
            }
            else
                jnewjobs.Instance.BringToFront();

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
                    indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
                    label3.Text = "Time Estimate";//change Header Name
                }
            
                if (!panel5.Controls.Contains(jreports.Instance))
                {
                    panel5.Controls.Add(jestimate.Instance);
                    jestimate.Instance.Dock = DockStyle.Fill;
                    jestimate.Instance.BringToFront();
                }
                else
                    jestimate.Instance.BringToFront();
           
           
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
                label3.Text = "Cost  Estimate";//change Header Name
            }
            if (!panel5.Controls.Contains(jcost.Instance))
            {
                panel5.Controls.Add(jcost.Instance);
                jcost.Instance.Dock = DockStyle.Fill;
                jcost.Instance.BringToFront();
            }
            else
                jcost.Instance.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
                label3.Text = "Reports";//change Header Name


            }
            if (!panel5.Controls.Contains(jreports.Instance))
            {
                panel5.Controls.Add(jreports.Instance);
                jreports.Instance.Dock = DockStyle.Fill;
                jreports.Instance.BringToFront();
            }
            else
                jreports.Instance.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void indi_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
                label3.Text = "status";//change Header Name


            }
            if (!panel5.Controls.Contains(status.Instance))
            {
                panel5.Controls.Add(status.Instance);
                status.Instance.Dock = DockStyle.Fill;
                status.Instance.BringToFront();
            }
            else
                status.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel4.Visible = false;


        }
       
    }

}
