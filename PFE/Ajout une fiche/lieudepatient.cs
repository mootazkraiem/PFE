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
    public partial class lieudepatient : Form
    {
        public static lieudepatient instance;
        public lieudepatient()
        {
            InitializeComponent();
            instance = this;
        }
        public void loadform(object Form)
        {
            if (this.panel.Controls.Count > 0)
            {
                this.panel.Controls.RemoveAt(0);

            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel.Controls.Add(f);
            this.panel.Tag = f;
            f.Show();

        }

        private void prenomtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void agetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
      
        private void genrecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = lieucombobox.Text;
            panel.Hide();
            

               
                if (a == "Autre") 
                {
                panel.Show();
                loadform(new Autrelieudepatient());
                }
            else
            {
                panel.Hide();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nomtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            motifdappel f = new motifdappel();
            f.Show();
            this.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            string idpatient = informationdepatient.instance.idpatienttxtbox.Text;
            string nom = informationdepatient.instance.nomtxtbox.Text;
            string prenom = informationdepatient.instance.prenomtxtbox.Text;
            int age = int.Parse(informationdepatient.instance.agetxtbox.Text);
            string genre = informationdepatient.instance.genrecombobox.Text;
            string lieupatient = informationdepatient.instance.lieudepatienttxtbox.Text;
            string gouvernorat = informationdepatient.instance.gouvernorattxtbox.Text;
            int telephone = int.Parse(informationdepatient.instance.idpatienttxtbox.Text);
            informationdepatient f = new informationdepatient();
            f.idpatienttxtbox.Text = idpatient;
            f.nomtxtbox.Text = nom;
            f.prenomtxtbox.Text = prenom;
            f.agetxtbox.Text = age.ToString();
            f.genrecombobox.Text = genre;
            f.lieudepatienttxtbox.Text = lieupatient;
            f.genrecombobox.Text = gouvernorat;
            f.idpatienttxtbox.Text = telephone.ToString();
            f.ShowDialog();
            
        }

        private void lieudepatient_Load(object sender, EventArgs e)
        {

        }
    }
}
