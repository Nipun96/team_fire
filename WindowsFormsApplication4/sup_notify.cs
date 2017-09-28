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
    public partial class sup_notify : UserControl
    {

        private static sup_notify _instance;
        public static sup_notify Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new sup_notify();
                return _instance;

            }


        }
        public sup_notify()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
