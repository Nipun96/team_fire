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
    public partial class inventry_dashboard : UserControl
    {
        private static inventry_dashboard _instance;
        public static inventry_dashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new inventry_dashboard();
                return _instance;
            }
        }

        public inventry_dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
