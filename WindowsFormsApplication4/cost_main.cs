using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class cost_main : Form
    {
        MySqlConnection con = new MySqlConnection();

        public cost_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;//side bar of the button
                label3.Text = "Daily Expenses";//change Header Name

               
            }
                if (!panel5.Controls.Contains(dailyexpenses.Instance))
            {
                panel5.Controls.Add(dailyexpenses.Instance);
                dailyexpenses.Instance.Dock = DockStyle.Fill;
                dailyexpenses.Instance.BringToFront();
            }
            else
                dailyexpenses.Instance.BringToFront();

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
            Environment.Exit(0);
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
            label3.Text = "Petty Cash";

            if (!panel5.Controls.Contains(cost_Pettycash.Instance))
            {
                panel5.Controls.Add(cost_Pettycash.Instance);
                cost_Pettycash.Instance.Dock = DockStyle.Fill;
                cost_Pettycash.Instance.BringToFront();
            }
            else
                cost_Pettycash.Instance.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
                label3.Text = "Budget";
            }
            if (!panel5.Controls.Contains(cost_Budget.Instance))
            {
                panel5.Controls.Add(cost_Budget.Instance);
                cost_Budget.Instance.Dock = DockStyle.Fill;
                cost_Budget.Instance.BringToFront();
            }
            else
                cost_Budget.Instance.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;
                label3.Text = "Income and Profit";
            }
                if (!panel5.Controls.Contains(cost_incomeprofit.Instance))
            {
                panel5.Controls.Add(cost_incomeprofit.Instance);
                cost_incomeprofit.Instance.Dock = DockStyle.Fill;
                cost_incomeprofit.Instance.BringToFront();
            }
            else
                cost_incomeprofit.Instance.BringToFront();

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
            label3.Text = "Payroll";
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
            label3.Text = "Report";

            if (!panel5.Controls.Contains(cost_Report.Instance))
            {
                panel5.Controls.Add(cost_Report.Instance);
                cost_Report.Instance.Dock = DockStyle.Fill;
                cost_Report.Instance.BringToFront();
            }
            else
                cost_Report.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel4.Visible = false;


        }
       
    }

}
