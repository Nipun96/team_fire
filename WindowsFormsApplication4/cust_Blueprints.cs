using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace WindowsFormsApplication4
{
    public partial class cust_Blueprints : UserControl
    {
        private static cust_Blueprints _instance;
        public static cust_Blueprints Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new cust_Blueprints();
                return _instance;
            }
        }

        public cust_Blueprints()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();

        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox.Width,pictureBox.Height);
            pictureBox.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Blueprints_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG| *.jpg", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    pictureBox.Image = Image.FromFile(ofd.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT custID,fullname,company FROM newcustrqst WHERE serviceType='Fire Detection System'");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];

           
            DataSet dss = db.dbse("SELECT * FROM newcustrqst WHERE fullname='" + s1.Text + "'");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }

        private void s1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataSet ds = db.dbse("SELECT custID,fullname,company FROM newcustrqst WHERE serviceType LIKE 'Fire Detection System'");
            bunifuCustomDataGrid1.DataSource = ds.Tables["load"];
        }
    }
}
