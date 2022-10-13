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
    public partial class AppelsSortie : Form
    {
        public AppelsSortie()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        private void AppelsSortie_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var medgen = db.Appeltable.Count(zz => zz.CleAppel.ToString() != "");
            nbtotaltxt.Text = medgen.ToString();
            var sec = db.Appeltable.Count(cc => cc.Validationmission == "Accomplie");
            nbappelregultxt.Text = sec.ToString();
            var permanencier = db.Appeltable.Count(cc => cc.Decisionderegulation == "Primaire");
            nbtransportprimtxt.Text = permanencier.ToString();
            var techsupp = db.Appeltable.Count(cc => cc.Decisionderegulation == "Sec transf");
            nbtranspsectxt.Text = techsupp.ToString();
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void BTNIMPR_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0,0,this.Size);
            printPreviewDialog1.ShowDialog();

        }
    }
}
