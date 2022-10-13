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
    public partial class informationdepatient : Form
    {
        public static informationdepatient instance;
        public informationdepatient()
        {
            InitializeComponent();
            instance = this;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void registerbtn_Click(object sender, EventArgs e)
        {
            if ( (string.IsNullOrEmpty(idpatienttxtbox.Text)) || (string.IsNullOrEmpty(nomtxtbox.Text)) || (string.IsNullOrEmpty(prenomtxtbox.Text)) || (string.IsNullOrEmpty(agetxtbox.Text)))
                {

                MessageBox.Show("Remplir les champs obligatoires");
            }
            else {
                lieudepatient f = new lieudepatient();
                f.Show();
                this.Hide(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            string numfiche =detailsdefiche.instance.numfichetxtbox.ToString();
            string dateappel = detailsdefiche.instance.appeldatetxtbox.Text;
            string heureappel = detailsdefiche.instance.heuredappeltxtbox.Text;
            string medreg = detailsdefiche.instance.medecinregtxtbox.Text;
            string nbvic = detailsdefiche.instance.nbvictimestxtbox.Text;
            string param = detailsdefiche.instance.paramtxtbox.Text;
            
            this.Close();
            detailsdefiche f = new detailsdefiche();
            f.numfichetxtbox.Text = numfiche;
            f.appeldatetxtbox.Text = dateappel;
            f.heuredappeltxtbox.Text = heureappel;
            f.medecinregtxtbox.Text = medreg;
            f.nbvictimestxtbox.Text = nbvic.ToString();
            f.paramtxtbox.Text = param ;
            f.ShowDialog();
            
        }

        private void informationdepatient_Load(object sender, EventArgs e)
        {

        }

        private void agetxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if ((sender as TextBox).Text.Count(char.IsDigit) >= 3){
                    e.Handled = true;
                }
            }
        }

        private void nomtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void prenomtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void agetxtbox_TextChanged(object sender, EventArgs e)
        {
            if(agetxtbox.Text.Length>3){
                MessageBox.Show("age invalide !");
            } }

        private void closebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
