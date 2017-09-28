using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication4
{
    public partial class sup_View : UserControl
    {
        

        private static sup_View _instance;
        public static sup_View Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new sup_View();
                return _instance;

            }


        }

        public sup_View()
        {
            InitializeComponent();
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM supplier");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void Search_Click(object sender, EventArgs e)
        {
      
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (Search.Text != "")
            {
                try {
                    Database db = new Database();
                    DataSet ds = db.dbse("SELECT * FROM supplier WHERE Sup_Id='" + Search.Text + "'");
                    bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }

            }
            else
                {
                MessageBox.Show("Please Insert ID to Search.! ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

            Database db = new Database();
            DataSet ds = db.dbse("SELECT Product_Name,Sup_Id FROM product WHERE Type = 'extinguishers' AND Product_Name IN (SELECT Product_Name FROM product GROUP BY Product_Name);");
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT Product_Name,Sup_Id FROM product WHERE Type = 'fire ditection' AND Product_Name IN (SELECT Product_Name FROM product GROUP BY Product_Name);");
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
        
            Database db = new Database();
            DataSet ds = db.dbse("SELECT Product_Name,Sup_Id FROM product WHERE Type = 'hydrent' AND Product_Name IN (SELECT Product_Name FROM product GROUP BY Product_Name);");
            bunifuCustomDataGrid2.DataSource = ds.Tables["load"];
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
       
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
