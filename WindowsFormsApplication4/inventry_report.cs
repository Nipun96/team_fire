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

    public partial class inventry_report : UserControl
    {
        private static inventry_report _instance;
        public static inventry_report Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new inventry_report();
                return _instance;
            }
        }
        public inventry_report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {

        }
    }
}
