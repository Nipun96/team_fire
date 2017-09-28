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
    public partial class mTraining : UserControl
    {
        String Gender ;
        Database db = new Database();
        private static mTraining _instance;
        public static mTraining Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new mTraining();
                return _instance;
            }
        }
        public mTraining()
        {
            InitializeComponent();
        }

        private void Training_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          

                
                
               string qu = "insert into `training` (Tpid,Name,Address,Tel_Phone,E_mail,Birthday,NIC,Gender) values('" + tpidtxt.Text + "','" + nametxt.Text + "','" + addtxt.Text + "','" + phtxt.Text + "','" + emltxt.Text + "','" + bodtxt.Text + "','" + nictxt.Text + "','"+Gender+"')";
                db.DBhand(qu);
            DataSet ds = db.dbse("SELECT * FROM training ");
            dg1.DataSource = ds.Tables["load"];
            dg1.Visible = true;
            dg2.Visible = false;



            //  MessageBox.Show("the record wass inserterd success");

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM training WHERE Tid ='"+ materialSingleLineTextField1.Text +"'");
            dg1.DataSource = ds.Tables["load"];
            dg1.Visible = true;
            dg2.Visible = false;

             
           // String a = db.dbgett("SELECT * FROM training WHERE Tid ='" + materialSingleLineTextField1.Text + "'");
            //tidtxt.Text = a;
        }

        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            DataGridViewRow selectedRow = dg1.Rows[r];

            tidtxt.Text = selectedRow.Cells[0].Value.ToString();
            tpidtxt.Text = selectedRow.Cells[1].Value.ToString();
            nametxt.Text = selectedRow.Cells[2].Value.ToString();
            addtxt.Text = selectedRow.Cells[3].Value.ToString();
            phtxt.Text = selectedRow.Cells[4].Value.ToString();
            emltxt.Text = selectedRow.Cells[5].Value.ToString();
            bodtxt.Text = selectedRow.Cells[6].Value.ToString();
            nictxt.Text = selectedRow.Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string qu = "Update training SET Tpid = '" + tpidtxt.Text + "', Name = '" +nametxt.Text + "', Address = '" + addtxt.Text + "', Tel_Phone = '" +phtxt.Text + "', E_mail = '" +emltxt.Text + "', Birthday = '" +bodtxt.Text + "',NIC = '" + nictxt.Text + "',Gender =  '"+Gender+"'";
            db.Dbupdate(qu);
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void emltxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bodtxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void nictxt_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void tidtxt_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void phtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if((phtxt.Text.Length == 10) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void nametxt_Enter(object sender, EventArgs e)
        {
            if(nametxt.Text == "Name")
            {
                nametxt.Text = "";
                nametxt.ForeColor = Color.Black;
            }
        }

        private void nametxt_Leave(object sender, EventArgs e)
        {
            if (nametxt.Text == "")
            {
                nametxt.Text = "Name";
                nametxt.ForeColor = Color.DimGray;
            }
        }

        private void nametxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void addtxt_Enter(object sender, EventArgs e)
        {
            if (addtxt.Text == "Address")
            {
                addtxt.Text = "";
                addtxt.ForeColor = Color.Black;
            }
        }

        private void phtxt_Enter(object sender, EventArgs e)
        {
            if (phtxt.Text == "Phone Number")
            {
                phtxt.Text = "";
                phtxt.ForeColor = Color.Black;
            }
        }

        private void emltxt_Enter(object sender, EventArgs e)
        {
            if (emltxt.Text == "E-Mail")
            {
                emltxt.Text = "";
                emltxt.ForeColor = Color.Black;
            }
        }

        private void nictxt_Enter(object sender, EventArgs e)
        {
            if (nictxt.Text == "Nic")
            {
                nictxt.Text = "";
                nictxt.ForeColor = Color.Black;
            }
        }

        private void addtxt_Leave(object sender, EventArgs e)
        {
            if (addtxt.Text == "")
            {
                addtxt.Text = "Address";
                addtxt.ForeColor = Color.DimGray;
            }
        }

        private void phtxt_Leave(object sender, EventArgs e)
        {
            if (phtxt.Text == "")
            {
                phtxt.Text = "Phone Number";
                phtxt.ForeColor = Color.DimGray;
            }
        }

        private void emltxt_Leave(object sender, EventArgs e)
        {
            if (emltxt.Text == "")
            {
                emltxt.Text = "E-Mail";
                emltxt.ForeColor = Color.DimGray;
            }
        }

        private void nictxt_Leave(object sender, EventArgs e)
        {
            if (nictxt.Text == "")
            {
                nictxt.Text = "Nic";
                nictxt.ForeColor = Color.DimGray;
            }
        }

        private void materialSingleLineTextField1_Leave(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text == "")
            {
                materialSingleLineTextField1.Text = "Search";
                materialSingleLineTextField1.ForeColor = Color.DimGray;
            }
        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox7_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox7.Text == "")
            {
                bunifuMaterialTextbox7.Text = "Company Name";
                bunifuMaterialTextbox7.ForeColor = Color.DimGray;
            }
        }

        private void bunifuMaterialTextbox8_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox8_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox8.Text == "")
            {
                bunifuMaterialTextbox8.Text = "Number Of Trainees";
                bunifuMaterialTextbox8.ForeColor = Color.DimGray;
            }
        }

        private void bunifuMaterialTextbox9_Leave(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox7_Enter(object sender, EventArgs e)
        {

            if (bunifuMaterialTextbox7.Text == "Company Name")
            {
                bunifuMaterialTextbox7.Text = "";
                bunifuMaterialTextbox7.ForeColor = Color.DimGray;
            }
        }

        private void bunifuMaterialTextbox8_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox8.Text == "Number Of Trainees")
            {
                bunifuMaterialTextbox8.Text = "";
                bunifuMaterialTextbox8.ForeColor = Color.DimGray;
            }

        }

        private void materialSingleLineTextField1_Enter(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text == "Search")
            {
                materialSingleLineTextField1.Text = "";
                materialSingleLineTextField1.ForeColor = Color.DimGray;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string date = bunifuDatepicker2.Value.Date.ToString("yyyy-MM-dd");
            string qu = "insert into training_program (Cusid,Noft,Date) values('" + bunifuMaterialTextbox8.Text + "',' 112','" + date + "')";
            db.DBhand(qu);

            String qu1= "select * From  training_program ORDER BY Tpid DESC";
           String tpid = db.dbgett(qu1);
            DataSet ds = db.dbse(qu1);
            dg2.DataSource = ds.Tables["load"];
            dg2.Visible = true;
            dg1.Visible = false;
           // tpidtxt.Text = tpid;
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(materialRadioButton1.Checked)
            {
                Gender = "M";
            }
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton2.Checked)
            {
                Gender = "F";
            }
        }

        private void dg2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            DataGridViewRow selectedRow = dg2.Rows[r];

            tpidtxt.Text = selectedRow.Cells[0].Value.ToString();
           
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dg2.Visible = true;
            dg1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dg1.Visible = true;
            dg2.Visible = false;
        }
    }
}
