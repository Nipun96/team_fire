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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Maintaine Form1 = new Maintaine();
            Form1.Visible = true;
            main Form3 = new main();
            Form3.Visible = false;


        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            vehicle_main Form1 = new vehicle_main();
            Form1.Visible = true;
            main Form3 = new main();
            Form3.Visible = false;
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            inventry_management_main Form1 = new inventry_management_main();
            Form1.Visible = true;
            main Form3 = new main();
            Form3.Visible = false;
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            emp_main Form1 = new emp_main();
            Form1.Visible = true;
            main Form3 = new main();
            Form3.Visible = false;
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            supplier_main Form1 = new supplier_main();
            Form1.Visible = true;
            main Form3 = new main();
            Form3.Visible = false;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Customer Form1 = new Customer();
            Form1.Visible = true;
            main Form3 = new main();
            Form3.Visible = false;
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            job_main Form1 = new job_main();
            Form1.Visible = true;
            main Form3 = new main();
            Form3.Visible = false;
        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            cost_main Form1 = new cost_main();
            Form1.Visible = true;
            main Form3 = new main();
            Form3.Visible = false;
        }
    }
}
