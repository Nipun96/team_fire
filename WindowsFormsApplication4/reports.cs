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

    public partial class reports : UserControl
    {
        private static reports _instance;
        public static reports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new reports();
                return _instance;
            }
        }
        public reports()
        {
            InitializeComponent();
        }
    }
}
