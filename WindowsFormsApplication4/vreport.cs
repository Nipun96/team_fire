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
    public partial class vreport : UserControl
    {
        private static vreport _instance;
        public static vreport Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new vreport();
                return _instance;
            }
        }
        public vreport()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
