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
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using Bunifu.Framework.UI;

namespace WindowsFormsApplication4
{
    public partial class vregister : UserControl
    {
        private static vregister _instance;


        public static vregister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new vregister();
                return _instance;
            }
        }
        public vregister()
        {
            InitializeComponent();
            genarateID();
        }
        public void regexp(String re,TextBox tb,Label lbl,String s)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                lbl.ForeColor = Color.Green;
                lbl.Text = s + "Valid";
            }
            else
            {
                lbl.ForeColor = Color.Red;
                lbl.Text = s + "Invalid";
            }
        }
     //  SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JAL40UR\SQLEXPRESS;Initial Catalog=vehicleDB;Integrated Security=True;Pooling=False");
        string vehicleid ="VH";
        private void genarateID()
        {
            Database1 db = new Database1();
            MySqlConnection conn = db.getConnection();
            MySqlCommand cmd = new MySqlCommand("select Count(vehicleID) from register",conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            vehicleID.Text = vehicleid + i.ToString();

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            try
            {

                //byte[] image = null;
                //FileStream streem = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                //BinaryReader brs = new BinaryReader(streem);
                //image = brs.ReadBytes((int)streem.Length);
                MemoryStream ms = new MemoryStream();
                image1.Image.Save(ms, image1.Image.RawFormat);
                byte[] img = ms.ToArray();

                bool test = Validte_Data();
                if (test == true)
                {
                    Database1 db = new Database1();
                    MySqlConnection conn = db.getConnection();
                    MySqlCommand cmd = conn.CreateCommand();
                    string status = "Aviliable";
                    cmd.CommandText = "insert into register (vehicleID,vNo,category,vModel,chassisNo,fuelType,engineNo,manufactYear,image,status) values('" + vehicleID.Text + "','" + vNo.Text + "','" + category.Text + "','" + vModel.Text + "','" + Convert.ToInt32(chassisNo.Text) + "','" + fuelType.Text + "','" + Convert.ToInt32(engineNo.Text) + "','" + manufactYear.Text + "',@img,'" + status + "')";
                    cmd.Parameters.Add(new MySqlParameter("@img", MySqlDbType.LongBlob));
                    cmd.Parameters["@img"].Value = img;

                    // VehicleNo,vehicleManufact,vehicleModel,chassieNo,fuelType,enginNo,manufactYear ,'" + txt2.Text + "','" + txt3.Text + "','" + txt4.Text + "'," + txt5.Text + "','" + txt6.Text + "','" + txt7.Text + "','" + txt8.Text + "
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    genarateID();
                    MessageBox.Show("the record wass inserterd success");
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialSingleLineTextField4_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            vehicleID.Text = "";
            vNo.Text = "";
            category.Text = "";
            vModel.Text = "";
            chassisNo.Text = "";
            fuelType.Text = "";
            engineNo.Text = "";
            manufactYear.Text = "";
            genarateID();
        }

        string imageLocation = "";
     
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                imageLocation = dialog.FileName.ToString();
                image1.ImageLocation = imageLocation;
            }
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private bool Validte_Data()
        {
            Regex validate_vNo = new Regex("^([a-zA-Z]{2,3}[0-9]{4})$");
            Regex Validate_model = new Regex("^[a-zA-Z]{1,20}$");
            Regex validate_chassie = new Regex("^[0-9]{5}$");
            Regex validate_engineNo = new Regex("^[0-9]{5}$");
            Regex validate_year = new Regex("^[0-9]{4}$");

            if (!validate_vNo.IsMatch(vNo.Text))
            {
                MessageBox.Show("Vehicle Number Not correct");
            }
            else
            {
                if (!Validate_model.IsMatch(vModel.Text))
                {
                    MessageBox.Show("Model not correct format");
                   
                   
                }
                else
                {
                    if (!validate_chassie.IsMatch(chassisNo.Text))
                    {
                        MessageBox.Show("chassie Number not Correct");
                    }
                    else
                    {
                        if (!validate_engineNo.IsMatch(engineNo.Text))
                        {
                            MessageBox.Show("Engine number not correct");
                        }
                        else
                        {
                            if (!validate_year.IsMatch(manufactYear.Text))
                            {
                                MessageBox.Show("Manufacture year not correct");
                            }
                           
                            else
                            {
                                return true;
                              
                            }
                            return false;
                        }
                        return false;
                    }
                    return false;
                }
                return false;

            }
            return false;

        }


    }
}





