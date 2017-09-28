using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Types;
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class inventry_update_stocks : UserControl
    {
        

        Database db = new Database();

        string path;


        private static inventry_update_stocks _instance;
        public static inventry_update_stocks Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new inventry_update_stocks();
                return _instance;
            }
        }
        public inventry_update_stocks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stockNo.Text !="Stock No" && date.Text != "YYYY-MM-DD" && unitPrice.Text !="Unit Price" && sellingPrice.Text != "Selling Price" && quantity.Text != "Quantity" && warranty.Text !="Warranty" && brand.Text !="Brand" && itemId.Visible == false && itemId_.Visible == false)
            {

                string qu = "insert into item (quantity,stockNo,unitPrice,sellingPrice,warranty,itemName,date,type,brand,supplierName) values('" + quantity.Text + "','" + stockNo.Text + "','" + unitPrice.Text + "','" + sellingPrice.Text + "','" + warranty.Text + "','" + itemName.Text + "','" + date.Text + "','" + type.Text + "','" + brand.Text + "','" + supplier.Text + "')";
                db.DBhand(qu);


                DataSet ds = db.dbse("SELECT itemId,stockNo,itemName,type,date,quantity,brand,unitPrice,sellingPrice,warranty,supplierName FROM inventry.item");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
            }
            else
            {
                MessageBox.Show("Something Wrong , Please Check Values Again !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void addItems_Load(object sender, EventArgs e)
        {
           

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
        }  

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear?", "Clear Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                quantity.Text ="Quentity";
                stockNo.Text = "Stock No";
                unitPrice.Text = "Unit Price";
                sellingPrice.Text = "Selling Price";
                warranty.Text = "Warranty";
                brand.Text = "Brand";
                date.Text = "YYYY-MM-DD";

                // metroComboBox1.Items.Clear();
                //metroComboBox1.Items.Add("Select a item");

                quantity.ForeColor = Color.DimGray;
                stockNo.ForeColor = Color.DimGray;
                unitPrice.ForeColor = Color.DimGray;
                sellingPrice.ForeColor = Color.DimGray;
                warranty.ForeColor = Color.DimGray;
                brand.ForeColor = Color.DimGray;
                date.ForeColor = Color.DimGray;

                itemId.Visible = false;
                itemId_.Visible = false;

            }


        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (this.type.Text == "Fire Ditection")
            {
                 path = @"C:\Users\Nipun\Documents\Visual Studio 2015\Projects\TeamFire_final 1.0\WindowsFormsApplication4\products\FireDitection.txt";

            }
            else if (this.type.Text == "Hydrent")
            {
                 path = @"C:\Users\Nipun\Documents\Visual Studio 2015\Projects\TeamFire_final 1.0\WindowsFormsApplication4\products\Hydrent.txt";
            }

            else if (this.type.Text == "Extingulshers")
            {
                 path = @"C:\Users\Nipun\Documents\Visual Studio 2015\Projects\TeamFire_final 1.0\WindowsFormsApplication4\products\Extingulshers.txt";
            }
            itemName.Items.Clear();

            try
            {


                StreamReader sr = new StreamReader(path);
                string x = sr.ReadToEnd();
                string[] y = x.Split(',');
                foreach (string s in y)
                {
                    itemName.Items.Add(s);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("error  : "+ee.Message);
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            itemId.Visible = true;
            itemId_.Visible = true;
            int r = e.RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[r];

            itemId.Text = selectedRow.Cells[0].Value.ToString();
            stockNo.Text = selectedRow.Cells[1].Value.ToString();
            itemName.Text = selectedRow.Cells[2].Value.ToString();
            type.Text = selectedRow.Cells[3].Value.ToString();
            date.Text = selectedRow.Cells[4].Value.ToString();
            quantity.Text = selectedRow.Cells[5].Value.ToString();
            brand.Text = selectedRow.Cells[6].Value.ToString();
            unitPrice.Text = selectedRow.Cells[7].Value.ToString();
            sellingPrice.Text = selectedRow.Cells[8].Value.ToString();
            warranty.Text = selectedRow.Cells[9].Value.ToString();
            supplier.Text = selectedRow.Cells[10].Value.ToString();

            quantity.ForeColor = Color.Black;
            stockNo.ForeColor = Color.Black;
            unitPrice.ForeColor = Color.Black;
            sellingPrice.ForeColor = Color.Black;
            warranty.ForeColor = Color.Black;
            brand.ForeColor = Color.Black;
            date.ForeColor = Color.Black;

        }

        private void warrenty_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void unitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void quantity_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void sellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void stockNo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void stockNo_Enter(object sender, EventArgs e)
        {
            if (stockNo.Text == "Stock No")
            {
                stockNo.Text = "";

                stockNo.ForeColor = Color.Black;
            }
        }
       

        private void stockNo_Leave_1(object sender, EventArgs e)
        {

        }

        private void stockNo_Leave(object sender, EventArgs e)
        {
            if (stockNo.Text == "")
            {
                stockNo.Text = "Stock No";

                stockNo.ForeColor = Color.DimGray;
            }

        }

        private void quantity_Enter(object sender, EventArgs e)
        {
            if (quantity.Text == "Quantity")
            {
                quantity.Text = "";

                quantity.ForeColor = Color.Black;
            }
        }

        private void quantity_Leave(object sender, EventArgs e)
        {
            if (quantity.Text == "")
            {
                quantity.Text = "Quantity";

                quantity.ForeColor = Color.DimGray;
            }
        }

        private void unitPrice_Enter(object sender, EventArgs e)
        {
            if (unitPrice.Text == "Unit Price")
            {
                unitPrice.Text = "";

                unitPrice.ForeColor = Color.Black;
            }
        }

        private void unitPrice_Leave(object sender, EventArgs e)
        {
            if (unitPrice.Text == "")
            {
                unitPrice.Text = "Unit Price";

                unitPrice.ForeColor = Color.DimGray;
            }
        }

        private void sellingPrice_Enter(object sender, EventArgs e)
        {
            if (sellingPrice.Text == "Selling Price")
            {
                sellingPrice.Text = "";

                sellingPrice.ForeColor = Color.Black;
            }
        }

        private void sellingPrice_Leave(object sender, EventArgs e)
        {
            if (sellingPrice.Text == "")
            {
                sellingPrice.Text = "Selling Price";

                sellingPrice.ForeColor = Color.DimGray;
            }
        }

        private void warranty_Enter(object sender, EventArgs e)
        {
            if (warranty.Text == "Warranty")
            {
                warranty.Text = "";

                warranty.ForeColor = Color.Black;
            }
        }

        private void warranty_Leave(object sender, EventArgs e)
        {
            if (warranty.Text == "")
            {
                warranty.Text = "Warranty";

                warranty.ForeColor = Color.DimGray;
            }
        }

        private void brand_Enter(object sender, EventArgs e)
        {
            if (brand.Text == "Brand")
            {
                brand.Text = "";

                brand.ForeColor = Color.Black;
            }

        }

        private void brand_Leave(object sender, EventArgs e)
        {
            if (brand.Text == "")
            {
                brand.Text = "Brand";

                brand.ForeColor = Color.Black;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (stockNo.Text != "Stock No" && date.Text != "YYYY-MM-DD" && unitPrice.Text != "Unit Price" && sellingPrice.Text != "Selling Price" && quantity.Text != "Quantity" && warranty.Text != "Warranty" && brand.Text != "Brand" )
            {
                string qu = "Update item SET type = '" + type.Text + "', date = '" + date.Text + "', stockNo = '" + stockNo.Text + "', unitPrice = '" + unitPrice.Text + "', itemName = '" + itemName.Text + "', sellingPrice = '" + sellingPrice.Text + "', quantity = '" + quantity.Text + "',warranty = '" + warranty.Text + "',supplierName = '" + supplier.Text + "',brand = '" + brand.Text + "' where itemId ='" + itemId.Text + "'";
                db.Dbupdate(qu);
            }else
            {
                MessageBox.Show("Somthing Wrong, please check values again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           


            DataSet ds = db.dbse("SELECT itemId,stockNo,itemName,type,date,quentity,brand,unitPrice,sellingPrice,warranty,supplierName FROM item");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = db.dbse("SELECT itemId,stockNo,itemName,type,date,quantity,brand,unitPrice,sellingPrice,warranty,supplierName FROM item");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        private void date_Enter(object sender, EventArgs e)
        {
            if (date.Text == "YYYY-MM-DD")
            {
                date.Text = "";

                date.ForeColor = Color.Black;
            }

        }

        private void date_Leave(object sender, EventArgs e)
        {
            if (date.Text == "")
            {
                date.Text = "YYYY-MM-DD";

                date.ForeColor = Color.DimGray;
            }

        }

        private void date_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void itemId_Click(object sender, EventArgs e)
        {
            MessageBox.Show("can't change this value", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (stockNo.Text != "Stock No" && date.Text != "YYYY-MM-DD" && unitPrice.Text != "Unit Price" && sellingPrice.Text != "Selling Price" && quantity.Text != "Quantity" && warranty.Text != "Warranty" && brand.Text != "Brand" && itemId.Visible == true && itemId_.Visible == true)
            {
                if (MessageBox.Show("Do you want to Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qu = "delete from item where itemId = '"+itemId.Text +"'";
                    db.Dbdelet(qu);
                }else
                {
                    MessageBox.Show("Something wrong please check values again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields are empty !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
