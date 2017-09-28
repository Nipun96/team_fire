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
    public partial class mReminder : UserControl
    {
        string id;
        Database db = new Database();
        private static mReminder _instance;
        public static mReminder Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new mReminder();
                return _instance;
            }
        }
        public mReminder()
        {
            InitializeComponent();
        }

        private void Reminder_Load(object sender, EventArgs e)
        {
            DataSet ds = db.dbse("SELECT Rem_Id,Cusid,Date FROM reminder ");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Enter(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text == "Search Name")
            {
                materialSingleLineTextField1.Text = "";
                materialSingleLineTextField1.ForeColor = Color.Black;
            }
        }

        private void materialSingleLineTextField1_Leave(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text == "")
            {
                materialSingleLineTextField1.Text = "Search Name";
                materialSingleLineTextField1.ForeColor = Color.DimGray;
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[r];

            materialSingleLineTextField1.Text = selectedRow.Cells[1].Value.ToString();

            id = selectedRow.Cells[0].Value.ToString();
            DataSet ds = db.dbse("SELECT * FROM reminder WHERE Rem_Id='" + id +"'");
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }
    }
}
