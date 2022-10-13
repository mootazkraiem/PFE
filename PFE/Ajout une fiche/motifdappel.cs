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
    public partial class motifdappel : Form
    { 
        public static motifdappel instance ;
        public motifdappel()
        {
            InitializeComponent();
            instance = this;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
      
        private void registerbtn_Click(object sender, EventArgs e)
        {
            
            Decisionderegulation f = new Decisionderegulation();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            string lieup = lieudepatient.instance.lieucombobox.Text;
            string autrelieu = Autrelieudepatient.instance.autrelieutxtbox.Text;
            string hopital = Autrelieudepatient.instance.hopitaltxtbox.Text;
            string service = Autrelieudepatient.instance.servicetxtbox.Text;
            lieudepatient f = new lieudepatient();
            f.lieucombobox.Text = lieup;

            f.ShowDialog();
          
        }

        private void motifdappel_Load(object sender, EventArgs e)
        {

        }
    }
}
