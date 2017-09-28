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
    public partial class Maintaine : Form
    {
        public Maintaine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
                label3.Text = "Request";//change Header Name

               
            }
                if (!panel5.Controls.Contains(mRequest.Instance))
            {
                panel5.Controls.Add(mRequest.Instance);
                mRequest.Instance.Dock = DockStyle.Fill;
                mRequest.Instance.BringToFront();
            }
            else
                mRequest.Instance.BringToFront();

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
            label3.Text = "Estimation";//change Header Name

            if (!panel5.Controls.Contains(Estimation.Instance))
            {
                panel5.Controls.Add(Estimation.Instance);
                Estimation.Instance.Dock = DockStyle.Fill;
                Estimation.Instance.BringToFront();
            }
            else
                Estimation.Instance.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
            label3.Text = "Reminder";//change Header Name

            if (!panel5.Controls.Contains(mReminder.Instance))
            {
                panel5.Controls.Add(mReminder.Instance);
                mReminder.Instance.Dock = DockStyle.Fill;
                mReminder.Instance.BringToFront();
            }
            else
                mReminder.Instance.BringToFront();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
                label3.Text = "Coustomer Confermation";//change Header Name

            }
                if (!panel5.Controls.Contains(CustomerConf.Instance))
            {
                panel5.Controls.Add(CustomerConf.Instance);
                CustomerConf.Instance.Dock = DockStyle.Fill;
                CustomerConf.Instance.BringToFront();
            }
            else
                CustomerConf.Instance.BringToFront();

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
            label3.Text = "Training";
            if (!panel5.Controls.Contains(mTraining.Instance))
            {
                panel5.Controls.Add(mTraining.Instance);
                mTraining.Instance.Dock = DockStyle.Fill;
                mTraining.Instance.BringToFront();
            }
            else
                mTraining.Instance.BringToFront();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel4.Visible = false;


        }
       
    }

}
