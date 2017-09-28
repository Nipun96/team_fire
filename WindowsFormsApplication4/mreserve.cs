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
    public partial class mreserve : UserControl
    {
        private static mreserve _instance;
        public static mreserve Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new mreserve();
                return _instance;
            }
        }

        public mreserve()
        {
            InitializeComponent();
        }
    }
}
