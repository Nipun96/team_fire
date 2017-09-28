using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class inventry_storage : UserControl
    {
        Database db = new Database();

        string path;

        private static inventry_storage _instance;
        public static inventry_storage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new inventry_storage();
                return _instance;
            }
        }

        public inventry_storage()
        {
            InitializeComponent();
        }

        private void storage_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void itemNameNew_Enter(object sender, EventArgs e)
        {
            if (itemNameNew.Text == "Item Name")
            {
                itemNameNew.Text = "";

                itemNameNew.ForeColor = Color.Black;
            }
        }

        private void itemNameNew_Leave(object sender, EventArgs e)
        {
            if (itemNameNew.Text == "")
            {
                itemNameNew.Text = "Item Name";

                itemNameNew.ForeColor = Color.Black;
            }

        }

        private void itemNameNew_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.itemNameNew.Text == "Fire Ditection")
            {
                path = @"C:\Users\Nipun\Documents\Visual Studio 2015\Projects\TeamFire_final 1.0\WindowsFormsApplication4\products\FireDitection.txt";

            }
            else if (this.itemNameNew.Text == "Hydrent")
            {
                path = @"C:\Users\Nipun\Documents\Visual Studio 2015\Projects\TeamFire_final 1.0\WindowsFormsApplication4\products\Hydrent.txt";
            }

            else if (this.itemNameNew.Text == "Extingulshers")
            {
                path = @"C:\Users\Nipun\Documents\Visual Studio 2015\Projects\TeamFire_final 1.0\WindowsFormsApplication4\products\Extingulshers.txt";
            }

            string newValue = itemNameNew.Text;

            try
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(newValue);

                
            }
            catch (Exception ee)
            {
                MessageBox.Show("The Process Failed :" + ee.Message);
            }
        }

        private void type_storage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.type_storage.Text == "Fire Ditection")
            {
                path = @"C:\Users\Nipun\Documents\Visual Studio 2015\Projects\TeamFire_final 1.0\WindowsFormsApplication4\products\FireDitection.txt";

            }
            else if (this.type_storage.Text == "Hydrent")
            {
                path = @"C:\Users\Nipun\Documents\Visual Studio 2015\Projects\TeamFire_final 1.0\WindowsFormsApplication4\products\Hydrent.txt";
            }

            else if (this.type_storage.Text == "Extingulshers")
            {
                path = @"C:\Users\Nipun\Documents\Visual Studio 2015\Projects\TeamFire_final 1.0\WindowsFormsApplication4\products\Extingulshers.txt";
            }
            item_storage.Items.Clear();

            try
            {


                StreamReader sr = new StreamReader(path);
                string x = sr.ReadToEnd();
                string[] y = x.Split(',');
                foreach (string s in y)
                {
                    item_storage.Items.Add(s);
                }
                sr.Close();
            }
            catch(Exception ee)
            {
                MessageBox.Show("can't load items : ", ee.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = db.dbse("SELECT itemName,sum(quantity) As quantity FROM item where itemName ='"+item_storage.Text+"'");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DataSet ds = db.dbse("SELECT itemName,sum(quantity) As quantity FROM item where type = 'Fire Ditection' group by itemName");
                bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
            }

            else if (radioButton2.Checked)
            
                {
                    DataSet ds = db.dbse("SELECT itemName,sum(quantity) As quantity FROM item where type = 'Hydrent' group by itemName");
                    bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
                }
                else if (radioButton3.Checked)
                {
                    DataSet ds = db.dbse("SELECT itemName,sum(quantity) As quantity FROM item where type = 'Extingulshers' group by itemName");
                    bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
                }
            
        }
    }
}
