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
    public partial class Decisionderegulation : Form
    {
        public static Decisionderegulation instance;
        public Decisionderegulation()
        {
            InitializeComponent();
            instance=this;
        }
      
        private void registerbtn_Click(object sender, EventArgs e)
        {
           
            Bilandequipe f = new Bilandequipe();
            f.Show();
            this.Hide();
        }

        private void decisionderegulationcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void vehiculeengagecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            string motifapp = motifdappel.instance.motifdappelcombobox.Text;
            string objetdemande = motifdappel.instance.Objetdemandetxtbox.Text;
            motifdappel f = new motifdappel();
            f.motifdappelcombobox.Text = motifapp;
            f.Objetdemandetxtbox.Text = objetdemande;
            f.ShowDialog();
            
        }
    }
}
