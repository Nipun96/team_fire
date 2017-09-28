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
    public partial class Estimation : UserControl
    {



        int currentRow;


        private static Estimation _instance;
        public static Estimation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Estimation();
                return _instance;
            }
        }
    public Estimation()
        {
            InitializeComponent();
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (materialRadioButton2.Checked)
            {
                this.Selecttype.Items.Clear();
                this.Selecttype.Items.Add("Select Items");
                this.Selecttype.Items.Add("hItem1");
                this.Selecttype.Items.Add("hItem2");
                this.Selecttype.Items.Add("hItem3");
                this.Selecttype.Items.Add("hItem4");
                this.Selecttype.Items.Add("hItem5");
                this.Selecttype.Items.Add("hItem6");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Estimation_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            
            this.bunifuCustomDataGrid1.Rows.Add(Selecttype.Text, bunifuMetroTextbox1.Text, 5, 6654);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                bunifuCustomDataGrid1.Rows.RemoveAt(currentRow);
            }
            catch(Exception )
            {
                MessageBox.Show("Error");
            } 
            
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
             currentRow = bunifuCustomDataGrid1.CurrentCell.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
                {

                    DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[i];

                    string c1 = selectedRow.Cells[0].Value.ToString();
                    string c2 = selectedRow.Cells[1].Value.ToString();
                    string c3 = selectedRow.Cells[2].Value.ToString();
                    string c4 = selectedRow.Cells[3].Value.ToString();

                    /* String c1 = selectedRow.Cells[0].Value.ToString();
                     String c2 = selectedRow.Cells[1].Value.ToString();
                     String c3 = selectedRow.Cells[2].Value.ToString();
                     String c4 = selectedRow.Cells[3].Value.ToString()
 */
                    /*  int c1 = Convert.ToInt32(selectedRow.Cells[0].Value);
                      int c2 = Convert.ToInt32(selectedRow.Cells[1].Value);
                      int c3 = Convert.ToInt32(selectedRow.Cells[2].Value);
                      Double c4 = Convert.ToDouble(selectedRow.Cells[3].Value);
                      */

                    string qu = "INSERT INTO estimate VALUES ('"+ c1 + "',' "+ c2 + "',' "+ c3 + "',' "+ c4 + "')";
                    db.DBhand(qu);

                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("Error" + ee);
               
            }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(materialRadioButton1.Checked)
            {

                this.Selecttype.Items.Clear();
                this.Selecttype.Items.Add("Select Items");
                this.Selecttype.Items.Add("fItem1");
                this.Selecttype.Items.Add("fItem2");
                this.Selecttype.Items.Add("fItem3");
                this.Selecttype.Items.Add("fItem4");
                this.Selecttype.Items.Add("fItem5");
                this.Selecttype.Items.Add("fItem6");
                
            }
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (materialRadioButton3.Checked)
            {

                this.Selecttype.Items.Clear();
                this.Selecttype.Items.Add("Select Item");
                this.Selecttype.Items.Add("EItem1");
                this.Selecttype.Items.Add("EItem2");
                this.Selecttype.Items.Add("EItem3");
                this.Selecttype.Items.Add("EItem4");
                this.Selecttype.Items.Add("EItem5");
                this.Selecttype.Items.Add("EItem6");

            }
        }

        private void Selecttype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
