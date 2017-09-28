using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class CustomerConf : UserControl
    {
        string id;
        string Status;


        Database db = new Database();
        private static CustomerConf _instance;
        public static CustomerConf Instance
        {

            get
            {
                if (_instance == null)
                    _instance = new CustomerConf();
                return _instance;
            }
        }
        public CustomerConf()
        {
            InitializeComponent();
        }

        private void Addnewrq_Load(object sender, EventArgs e)
        {
            DataSet ds = db.dbse("SELECT * FROM `Cus_conf` ");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string date = bunifuDatepicker2.Value.Date.ToString("yyyy-MM-dd");
                id = id + 1;

                //string rqid = "12222222";
                string qu = "insert into Cus_conf (confid,CusId,Status,Discription,Date) values('" + id + "','" + id + "','" + Status + "','" + bunifuMaterialTextbox1.Text + "','" + date + "')";
                db.DBhand(qu);
                DataSet ds = db.dbse("SELECT * FROM Cus_conf ");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
            }
            catch (Exception ee)
            {
                MessageBox.Show("error" + ee);
            }
            
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

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "Name")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor = Color.Black;
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

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "Search Name";
                bunifuMaterialTextbox1.ForeColor = Color.DimGray;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DataSet ds = db.dbse("SELECT * FROM Customer WHERE Cus_Name ='" + materialSingleLineTextField1.Text + "'");
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }

        private void Accept_CheckedChanged(object sender, EventArgs e)
        {
            if(Accept.Checked)
            {
                Status = "Accept";
            }
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(materialRadioButton2.Checked)
            {
                Status = "Reject";
                bunifuMaterialTextbox1.Visible = true;
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = e.RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid2.Rows[r];

            materialSingleLineTextField1.Text = selectedRow.Cells[1].Value.ToString();
            id = selectedRow.Cells[1].Value.ToString();
        }
    }
}
