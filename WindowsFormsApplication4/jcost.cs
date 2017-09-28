using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class jcost : UserControl
    {
        private static jcost _instance;
        public static jcost Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new jcost();
                return _instance;
            }
        }
        public jcost()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            float dis;
            dis = float.Parse(bunifuMaterialTextbox4.Text);

            if (dis > 50)
            {
                float tot;
                
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jcurrentCost Form1 = new jcurrentCost();
            Form1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            jcCost c = new jcCost();
            c.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
