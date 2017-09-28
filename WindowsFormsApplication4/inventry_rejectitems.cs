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
    public partial class inventry_rejectitems : UserControl
    {
        Database db = new Database();

        string path;

        private static inventry_rejectitems _instance;
        public static inventry_rejectitems Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new inventry_rejectitems();
                return _instance;
            }
        }


        public inventry_rejectitems()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void rejectitems_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(date.Text !="YYYY-MM-DD" && reason.Text !="Reason" && description_reject.Text != "Description")
            {
                if (MessageBox.Show("Do you want to reject?", "Reject", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string qu = "insert into rejected_item (item_type_reject,item_name_reject,brand,quantity,reason,description,date) values('" + type_reject.Text + "','" + item_reject.Text + "','" + brand_reject.Text + "','" + quantity_reject.Text + "','" + reason.Text + "','" + description_reject.Text + "','" + date.Text + "')";
                    db.DBhand(qu);

                }

            }
            else
            {
                MessageBox.Show("something wrong, Check values again", "error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.type_reject.Text == "Fire Ditection")
            {
                path = @"C:\Users\Nipun\Documents\Visual Studio 2015\Projects\TeamFire_final 1.0\WindowsFormsApplication4\products\FireDitection.txt";

            }
            else if (this.type_reject.Text == "Hydrent")
            {
                path = @"C:\Users\Nipun\Documents\Visual Studio 2015\Projects\TeamFire_final 1.0\WindowsFormsApplication4\products\Hydrent.txt";
            }

            else if (this.type_reject.Text == "Extingulshers")
            {
                path = @"C:\Users\Nipun\Documents\Visual Studio 2015\Projects\TeamFire_final 1.0\WindowsFormsApplication4\products\Extingulshers.txt";
            }
            item_reject.Items.Clear();

            try
            {


                StreamReader sr = new StreamReader(path);
                string x = sr.ReadToEnd();
                string[] y = x.Split(',');
                foreach (string s in y)
                {
                    item_reject.Items.Add(s);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("error  : " + ee.Message);
            }
        }

        private void date_Enter(object sender, EventArgs e)
        {
            if (date.Text == "YYYY-MM-DD")
            {
                date.Text = "";

                
            }
        }

        private void date_Leave(object sender, EventArgs e)
        {
            if (date.Text == "")
            {
                date.Text = "YYYY-MM-DD";

                date.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = db.dbse("SELECT * FROM rejected_item");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        private void reason_Enter(object sender, EventArgs e)
        {
            if (reason.Text == "Reason")
            {
                reason.Text = "";

                reason.ForeColor = Color.Black;
            }
        }

        private void reason_Leave(object sender, EventArgs e)
        {
            if (reason.Text == "")
            {
                reason.Text = "Reason";

                reason.ForeColor = Color.Black;
            }
        }

        private void description_reject_Enter(object sender, EventArgs e)
        {
            if (description_reject.Text == "Description")
            {
                description_reject.Text = "";

                description_reject.ForeColor = Color.Black;
            }
        }

        private void description_reject_Leave(object sender, EventArgs e)
        {
            if (description_reject.Text == "")
            {
                description_reject.Text = "Description";

                description_reject.ForeColor = Color.DimGray;
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void date_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void reason_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
