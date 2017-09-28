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
    public partial class mRequest : UserControl
    {
        string id;
        String type;

        Database db = new Database();
        private static mRequest _instance;
        public static mRequest Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new mRequest();
                return _instance;
            }
        }
    public mRequest()
    {
        InitializeComponent();
    }

        private void status_Load(object sender, EventArgs e)
        {
            DataSet ds = db.dbse("SELECT * FROM `Maintaine_tequest` ");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
         

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = bunifuDropdown1.selectedValue.ToString();
            if (String.Compare(t1, "Select Type") == 0)

            {
                string date = bunifuDatepicker2.Value.Date.ToString("yyyy-MM-dd");
                DataSet ds = db.dbse("SELECT * FROM maintaine_tequest WHERE Date ='" + date + "'");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
            }else
            if (String.Compare(t1,"Extend System")==0)
                
            {
                string date = bunifuDatepicker2.Value.Date.ToString("yyyy-MM-dd");
                DataSet ds = db.dbse("SELECT * FROM maintaine_tequest WHERE Date ='" + date + "' AND Type ='"+ t1 +"'");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
            }
            else if(String.Compare(t1, "System Rapire") == 0)
            {
                string date = bunifuDatepicker2.Value.Date.ToString("yyyy-MM-dd");
                DataSet ds = db.dbse("SELECT * FROM maintaine_tequest WHERE Date ='" + date + "' AND Type ='" + t1 + "'");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
            }
            else if(String.Compare(t1, "More fire extinguishers") == 0)
            {
                string date = bunifuDatepicker2.Value.Date.ToString("yyyy-MM-dd");
                DataSet ds = db.dbse("SELECT * FROM maintaine_tequest WHERE Date ='" + date + "'  AND Type ='" + t1 + "'");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
            }
            else if (String.Compare(t1, "Extend System And More fire extinguishers") == 0)
            {
                string date = bunifuDatepicker2.Value.Date.ToString("yyyy-MM-dd");
                DataSet ds = db.dbse("SELECT * FROM maintaine_tequest WHERE Date ='" + date + "' AND Type ='" + t1 + "'");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
            }
            else if(String.Compare(t1, "System Rapire And More fire extinguishers") == 0)
            {
                string date = bunifuDatepicker2.Value.Date.ToString("yyyy-MM-dd");
                DataSet ds = db.dbse("SELECT * FROM maintaine_tequest WHERE Date ='" + date + "'  AND Type ='" + t1 + "'");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
            }
            else if(String.Compare(t1, "Training Program") == 0)
            {
                string date = bunifuDatepicker2.Value.Date.ToString("yyyy-MM-dd");
                DataSet ds = db.dbse("SELECT * FROM maintaine_tequest WHERE Date ='" + date + "'  AND Type ='" + t1 + "'");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
            }
           
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DataSet  ds = db.dbse("SELECT * FROM Customer WHERE Cus_Name ='" + materialSingleLineTextField1.Text + "'" );
            bunifuCustomDataGrid3.DataSource = ds.Tables["load"];
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid2.Rows[r];

            materialSingleLineTextField1.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            


            string date = bunifuDatepicker2.Value.Date.ToString("yyyy-MM-dd");
            id = id + 1;
             
            //string rqid = "12222222";
            string qu = "insert into `maintaine_tequest` (Reqid,CusId,Type,Date) values('"+ id+"','" + materialSingleLineTextField1.Text + "','" + bunifuDropdown2.selectedValue.ToString()+ "','" + date + "')";
            db.DBhand(qu);
            DataSet ds = db.dbse("SELECT * FROM `Maintaine_tequest` ");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];

        }

        private void bunifuCustomDataGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid3.Rows[r];

            materialSingleLineTextField1.Text = selectedRow.Cells[1].Value.ToString();
             id = selectedRow.Cells[1].Value.ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            
                Estimation.Instance.BringToFront();
           
        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

