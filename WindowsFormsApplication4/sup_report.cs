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
    public partial class sup_report : UserControl
    {


        private static sup_report _instance;
        public static sup_report Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new sup_report();
                return _instance;

            }


        }

        public sup_report()
        {
            InitializeComponent();
        }
    }
}
