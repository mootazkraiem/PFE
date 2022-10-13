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
    public partial class register : Form

    {
       
        public register()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        registerclassDataContext db = new registerclassDataContext();
        private bool Isvalid(string user)

        {



            registerclassDataContext db = new registerclassDataContext();

            var st = from s in db.registertbl

                     where s.identifiant == identifianttxtbox.Text

                    

                     select s;



            if (st.Any())

            {

                return true;
            }
            else
            {

                return false;

            }

        }
        private void registerbtn_Click(object sender, EventArgs e)
        {
            string nom = nomtxtbox.Text;
            string prenom = prenomtxtbox.Text;
            string  telephone = telephonetxtbox.Text;
            string identifiant = identifianttxtbox.Text;
            string motdepasse = motdepassetxtbox.Text;
            string role = roletxtbox.Text;
            string service = servicecombobox.Text;
            if ((string.IsNullOrEmpty(nom)) || (string.IsNullOrEmpty(prenom)) || (string.IsNullOrEmpty(telephone)) || (string.IsNullOrEmpty(identifiant)) || (string.IsNullOrEmpty(motdepasse)) || (string.IsNullOrEmpty(role)) || (string.IsNullOrEmpty(service)))
            {
                MessageBox.Show("Remplir tous les champs !");
            }
            else if (Isvalid(identifiant))
            {
                MessageBox.Show("l'identifiant existe deja !");
            }
            else
            {
                var st = new registertbl
                {

                    nom = nom,
                    prenom = prenom,
                    telephone = telephone,
                    identifiant = identifiant,
                    motdepasse = motdepasse,
                    role = role,
                    service=service,




                };

                db.registertbl.InsertOnSubmit(st);
                db.SubmitChanges();
                MessageBox.Show("succesfully registred !");
                login l = new login();
                l.ShowDialog();
            }
           
        }
    
    }
}
