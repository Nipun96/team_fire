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
    public partial class ereport : UserControl
    {
        private static ereport _instance;
        public static ereport Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ereport();
                return _instance;
            }
        }
        public ereport()
        {
            InitializeComponent();
        }
    }
}
