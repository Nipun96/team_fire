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
    public partial class eloan : UserControl
    {
        private static eloan _instance;
        public static eloan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new eloan();
                return _instance;
            }
        }
        public eloan()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void loan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string qu = "insert into `loan` (empid,fname,lname,amount,date,description) values('" + empid2.Text + "','" + fname2.Text + "','" + lname2.Text + "','" + date.Text + "','"+ amount2.Text + "','"+ description2.Text + "')";
            db.DBhand(qu);

        }

        private void bunifuMaterialTextbox3_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void empid2_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
