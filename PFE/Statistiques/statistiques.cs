using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE
{
    public partial class statistiques : Form
        
    {
        public static statistiques instance;
        public statistiques()
        {
            InitializeComponent();
            instance = this;
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);

            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }
        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            loadform(new Resourceshum());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new SMURSRATTACHEs());
        }

        private void statistiques_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new AppelsSortie());
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadform(new Provenance_des_appels());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadform(new Decision());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            loadform(new orientationdepatient());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loadform(new intervention());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            acc a = new acc();
            a.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new stats());
        }
        Bitmap bmp;
        private void BTNIMPR_Click(object sender, EventArgs e)
        {
            this.Controls.Add(mainpanel);
            Graphics g = mainpanel.CreateGraphics();
            Size size = this.ClientSize;
            bmp = new Bitmap(Size.Width,Size.Height, g);
            g = Graphics.FromImage(bmp);
            Point point = PointToScreen(mainpanel.Location);
            g.CopyFromScreen(point.X, point.Y, 0, 0,size) ;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);

        }
    }
}
