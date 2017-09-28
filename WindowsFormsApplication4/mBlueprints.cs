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
    public partial class mBlueprints : UserControl
    {
        private static mBlueprints _instance;
        public static mBlueprints Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new mBlueprints();
                return _instance;
            }
        }

        public mBlueprints()
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
    }
}
