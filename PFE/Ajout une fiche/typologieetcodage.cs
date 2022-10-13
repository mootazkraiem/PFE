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
    public partial class typologieetcodage : Form
    {
        public static typologieetcodage instance;
        public typologieetcodage()
        {
            InitializeComponent();
            instance = this;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       
        private void registerbtn_Click(object sender, EventArgs e)
        {
            
            
            HorrairedelaMission f = new HorrairedelaMission();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            string destinationdesire = Destinationpatient.instance.destinationdesireetxtbox.Text;
            string obtenue = Destinationpatient.instance.obtenuetxtbox.Text;
            string destinationfinale = Destinationpatient.instance.destinationfinaletxtbox.Text;
            Destinationpatient f = new Destinationpatient();
            f.destinationdesireetxtbox.Text = destinationdesire;
            f.obtenuetxtbox.Text = obtenue;
            f.destinationdesireetxtbox.Text = destinationfinale;

            f.ShowDialog();
            
        }

        private void typologieetcodage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }
    }
}
