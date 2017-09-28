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

    public partial class cost_Report : UserControl
    {
        private static cost_Report _instance;
        public static cost_Report Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new cost_Report();
                return _instance;
            }
        }
        public cost_Report()
        {
            InitializeComponent();
        }
    }
}
