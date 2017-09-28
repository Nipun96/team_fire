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
    public partial class inventry_status : UserControl
    {
        private static inventry_status _instance;
        public static inventry_status Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new inventry_status();
                return _instance;
            }
        }
    public inventry_status()
    {
        InitializeComponent();
    }

        private void status_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

