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
    public partial class Bilandequipe : Form
    {
        public static Bilandequipe instance;
        public Bilandequipe()
        {
            InitializeComponent();
            instance = this;
           
        }

        private void Objetdemandetxtbox_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void registerbtn_Click(object sender, EventArgs e)
        {
            
           
            Destinationpatient f = new Destinationpatient();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            string decisionderegulation = Decisionderegulation.instance.decisionderegulationcombobox.Text;
            string vehiculeengage = Decisionderegulation.instance.vehiculeengagecomboBox.Text;
            string medecins = Decisionderegulation.instance.medecinscomboBox.Text;
            Decisionderegulation f = new Decisionderegulation();
            f.decisionderegulationcombobox.Text = decisionderegulation;
            f.vehiculeengagecomboBox.Text = vehiculeengage;
            f.medecinscomboBox.Text = medecins;
            f.ShowDialog();
          
        }

        private void Bilandequipe_Load(object sender, EventArgs e)
        {

        }
    }
}
