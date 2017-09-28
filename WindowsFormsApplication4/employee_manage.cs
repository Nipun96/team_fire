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
using System.IO;

namespace WindowsFormsApplication4
{

    public partial class employee_manage : UserControl
    {
        string gender;
        private static employee_manage _instance;
        public static employee_manage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new employee_manage();
                return _instance;
            }
        }

    public employee_manage()
    {
        InitializeComponent();
    }
       // SqlConnection con = new SqlConnection("Data Source=DESKTOP-C7H3335;Initial Catalog=emp;Integrated Security=True");
        private string imageLocation;

        private void status_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (male.Checked){
                gender = "M";

            }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Database db = new Database();

            /*byte[] image = null;
            FileStream streem = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            image = brs.ReadBytes((int)streem.Length);
            */
            String dob = dob1.Value.Date.ToString("yyyy-MM-dd");
            if (fname.Text != "" && lname.Text != "" && address1.Text != "" && address2.Text != "" && city.Text != "" && nic.Text != "" && tel.Text != "" && cardid.Text != "" && salary.Text != "" && rpt.Text != "" && rpot.Text != "" && empid.Text != "")
            {


                string qu = "insert into emp_reg (fname,lname,dob,gender,address1,address2,city,nic,tel,position,cardid,basic_salary,rate_per_hour,rate_per_ot_hour,empid) values('" + fname.Text + "','" + lname.Text + "','" + dob + "','" + gender + "','" + address1.Text + "','" + address2.Text + "','" + city.Text + "','" + nic.Text + "','" + Convert.ToInt32(tel.Text) + "','" + position.Text + "','" + Convert.ToInt32(cardid.Text) + "','" + salary.Text + "','" + rpt.Text + "','" + rpot.Text + "','" + empid.Text + "')";
                db.DBhand(qu);

            }
            else
            {
                MessageBox.Show("can't have empty value");
            }
            /* try
             {

                 byte[] image = null;
                 FileStream streem = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                 BinaryReader brs = new BinaryReader(streem);
                 image = brs.ReadBytes((int)streem.Length);


                 Database db = new Database();
                 SqlConnection conn = db.getConnection();
                 SqlCommand cmd = conn.CreateCommand();

                 cmd.CommandText = "insert into emp_reg (fname,lname,dob,gender,address1,address2,city,nic,tel,position,cardid,image) values('" + fname.Text + "','" + lname.Text + "','" + dob.Text + "','" + male.Text + "','" + address1.Text + "','" + address2.Text + "','" + city.Text + "','" + nic.Text + "','" + Convert.ToInt32(tel.Text) + "','" + position.Text + "','" + Convert.ToInt32(cardid.Text) + "',@image1)";
                 // ,lname,dob,gender,address1,address2,city,nic,tel,position,cardid

                 // "','" + txt2.Text + "','" + txt3.Text + "','" + txt4.Text + "','" + txt6.Text + "','" + txt7.Text + "','" + txt8.Text + "','" + txt9.Text + "','" + txt10.Text + "','" + txt11.Text + "','" + txt12.Text +"'
                 cmd.Parameters.Add(new SqlParameter("@image1", image));
                 cmd.ExecuteNonQuery();

                 conn.Close();

                 MessageBox.Show("the record wass inserterd success");
             }
             catch (SqlException ex)
             {
                 MessageBox.Show(Convert.ToString(ex));

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fname.Text = "";
            lname.Text = "";
            dob1.Text = "";
            male.Text = "";
            female.Text = "";
            address1.Text = "";
            address2.Text = "";
            city.Text = "";
            nic.Text = "";
            tel.Text = "";
            position.Text = "";
            cardid.Text = "";
            salary.Text = "";
            rpt.Text = "";
            rpot.Text = "";
            empid.Text = "";
            
        }

        private void bunifuMaterialTextbox9_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName.ToString();
                image1.ImageLocation = imageLocation;
            }
        }

        private void city_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            if (female.Checked)
            {
                gender = "F";
            }
        }

        private void tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar !='8') && (e.KeyChar != 46) && (e.KeyChar != 8))
                {
                e.Handled = true;
            }
            if((e.KeyChar == '.') && (( sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if(tel.Text.Length == 10 && (e.KeyChar != 46) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
           
        }

        private void fname_Enter(object sender, EventArgs e)
        {
            if(fname.Text =="First Name")
            {
                fname.Text = "";
                fname.ForeColor = Color.Black;
            }
        }

        private void lname_Enter(object sender, EventArgs e)
        {
            if (lname.Text == "Last Name")
            {
                lname.Text = "";
                lname.ForeColor = Color.Black;
            }
        }

        private void address1_Enter(object sender, EventArgs e)
        {
            if (address1.Text == "Enter address line 1")
            {
                address1.Text = "";
                address1.ForeColor = Color.Black;
            }
        }

        private void address2_Enter(object sender, EventArgs e)
        {
            if (address2.Text == "Enter address line 2")
            {
                address2.Text = "";
                address2.ForeColor = Color.Black;
            }
        }

        private void city_Enter(object sender, EventArgs e)
        {
            if (city.Text == "Enter city")
            {
               city.Text = "";
                city.ForeColor = Color.Black;
            }
        }

        private void nic_Enter(object sender, EventArgs e)
        {
            if (nic.Text == "Enter nic number")
            {
                nic.Text = "";
                nic.ForeColor = Color.Black;
            }
        }

        private void tel_Enter(object sender, EventArgs e)
        {
            if (tel.Text == "Enter Telephone number")
            {
                tel.Text = "";
                tel.ForeColor = Color.Black;
            }
        }

        private void cardid_Enter(object sender, EventArgs e)
        {
            if (cardid.Text == "Enter Card Id")
            {
                cardid.Text = "";
                cardid.ForeColor = Color.Black;
            }
        }

        private void salary_Enter(object sender, EventArgs e)
        {
            if (salary.Text == "Enter Basic salary")
            {
                salary.Text = "";
                salary.ForeColor = Color.Black;
            }
        }

        private void rpt_Enter(object sender, EventArgs e)
        {
            if (rpt.Text == "Enter rate per hour")
            {
                rpt.Text = "";
                rpt.ForeColor = Color.Black;
            }
        }

        private void rpot_Enter(object sender, EventArgs e)
        {
            if (rpot.Text == "Enter rate per ot hour")
            {
                rpot.Text = "";
                rpot.ForeColor = Color.Black;
            }
        }

        private void empid_Enter(object sender, EventArgs e)
        {
            if (empid.Text == "Enter employee id")
            {
                empid.Text = "";
                empid.ForeColor = Color.Black;
            }
        }

        private void fname_Leave(object sender, EventArgs e)
        {
              if (empid.Text == "")
            {
                empid.Text = "Enter employee id";
               // empid.Text = "";
                empid.ForeColor = Color.Black;
            }
        }

        private void lname_Leave(object sender, EventArgs e)
        {
            if (lname.Text == "")
            {
                lname.Text = "Last Name";
                lname.ForeColor = Color.Black;
            }
        }

        private void address1_Leave(object sender, EventArgs e)
        {
            if (address1.Text == "")
            {
                address1.Text = "Enter address line 1";
                address1.ForeColor = Color.Black;
            }
        }

        private void address2_Leave(object sender, EventArgs e)
        {
            if (address2.Text == "")
            {
                address2.Text = "Enter address line 2";
                address2.ForeColor = Color.Black;
            }
        }

        private void city_Leave(object sender, EventArgs e)
        {
            if (city.Text == "")
            {
                city.Text =" Enter city";
                city.ForeColor = Color.Black;
            }
        }

        private void nic_Leave(object sender, EventArgs e)
        {
            if (nic.Text == "")
            {
                nic.Text = "Enter nic number";
                nic.ForeColor = Color.Black;
            }
        }

        private void tel_Leave(object sender, EventArgs e)
        {
            if (tel.Text == "")
            {
                tel.Text = "Enter Telephone number";
                tel.ForeColor = Color.Black;
            }
        }

        private void cardid_Leave(object sender, EventArgs e)
        {
            if (cardid.Text == "")
            {
                cardid.Text = "Enter Card Id";
                cardid.ForeColor = Color.Black;
            }
        }

        private void salary_Leave(object sender, EventArgs e)
        {
            if (salary.Text == "")
            {
                salary.Text = "Enter Basic salary";
                salary.ForeColor = Color.Black;
            }
        }

        private void rpt_Leave(object sender, EventArgs e)
        {
            if (rpt.Text == "")
            {
                rpt.Text = "Enter rate per hour";
                rpt.ForeColor = Color.Black;
            }
        }

        private void rpot_Leave(object sender, EventArgs e)
        {

            if (rpot.Text == "")
            {
                rpot.Text = "Enter rate per ot hour";
                rpot.ForeColor = Color.Black;
            }
        }

        private void empid_Leave(object sender, EventArgs e)
        {
            if (empid.Text == "")
            {
                empid.Text = "Enter employee id";
                empid.ForeColor = Color.Black;
            }
        }

        private void fname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void nic_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void rpt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void lname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void empid_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void nic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '8') && (e.KeyChar != 'V') && (e.KeyChar != 'v') && (e.KeyChar !=46) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (nic.Text.Length == 10 && (e.KeyChar != 46) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }

        }
    }
    }



