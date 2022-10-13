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
    public partial class Destinationpatient : Form
    {
        public static Destinationpatient instance;
        public Destinationpatient()
        {
            InitializeComponent();
            instance = this;
        }

        private void Destinationpatient_Load(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void registerbtn_Click(object sender, EventArgs e)
        {
           
            typologieetcodage f = new typologieetcodage();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            string bilan = Bilandequipe.instance.bilantxtbox.Text;
            decimal gcs = decimal.Parse(Bilandequipe.instance.gcstxtbox.Text);
            string ta = Bilandequipe.instance.tatxtbox.Text;
            decimal pouls = decimal.Parse(Bilandequipe.instance.poulstxtbox.Text);
            decimal spo2 = decimal.Parse(Bilandequipe.instance.spo2txtbox.Text);
            decimal t = decimal.Parse(Bilandequipe.instance.Ttextbox.Text);
            decimal dextro = decimal.Parse(Bilandequipe.instance.dextrotextbox.Text);
            Bilandequipe f = new Bilandequipe();
            f.bilantxtbox.Text = bilan;
            f.gcstxtbox.Text = gcs.ToString();
            f.tatxtbox.Text = ta;
            f.poulstxtbox.Text = pouls.ToString();
            f.spo2txtbox.Text = spo2.ToString();
            f.Ttextbox.Text = t.ToString();
            f.dextrotextbox.Text = t.ToString();
            f.ShowDialog();
            
        }
    }
}
