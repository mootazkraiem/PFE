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
    public partial class HorrairedelaMission : Form
        
    {
        public static HorrairedelaMission instance ;
        public HorrairedelaMission()
        {
            InitializeComponent();
            instance = this;

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HorrairedelaMission_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
       
        private void registerbtn_Click(object sender, EventArgs e)
        {
          
         
            
            validationfinal f = new validationfinal();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            string typologiepathologie = typologieetcodage.instance.typologiepathologiebox.Text;
            string pathologie = typologieetcodage.instance.pathologiebox.Text;
            typologieetcodage f = new typologieetcodage();
            f.typologiepathologiebox.Text = typologiepathologie;
            f.pathologiebox.Text = pathologie;
            f.ShowDialog();
            
        }
    }
}
