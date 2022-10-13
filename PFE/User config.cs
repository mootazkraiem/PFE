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
    public partial class User_config : Form
    {
        public User_config()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        private void charge_load()
        {
            var per = from p in db.registertbl
                      select new
                      {
                          p.nom,
                          p.prenom,
                          p.telephone,
                          p.identifiant,
                          p.motdepasse,
                          p.role
                      };
            datagridview1.DataSource = per;

        }
        private void User_config_Load(object sender, EventArgs e)
        {
            charge_load();
            

        }

        private void modifierbtn_Click(object sender, EventArgs e)
        {
            var per = db.registertbl.Single(x => x.identifiant == (paridentiftxtbox.Text));
            per.prenom = prenomtxtbox.Text;
            per.telephone = telephonetxtbox.Text;
            per.motdepasse = motdpassetxtbox.Text;
            per.role = roletxtbox.Text;

            db.SubmitChanges();
            charge_load();
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (byidtxtbox.Text != "")
            {
                var user = db.registertbl.SingleOrDefault(x => x.identifiant == (paridentiftxtbox.Text));
                if (user != null)
                {
                    nomtxtbox.Text = user.nom;
                    prenomtxtbox.Text = user.prenom;
                    telephonetxtbox.Text = user.telephone;
                    identifianttxtbox.Text = user.identifiant;
                    motdpassetxtbox.Text = user.motdepasse;
                    roletxtbox.Text = user.role;

                }
                else MessageBox.Show("cet ID n'existe pas");
            }
            else MessageBox.Show("saiser l'ID svp");
        }

        private void Supprimerbtn_Click(object sender, EventArgs e)
        {
            var per = db.registertbl.Single(x => x.identifiant == (paridentiftxtbox.Text));
            db.registertbl.DeleteOnSubmit(per);
            db.SubmitChanges();
            charge_load();
        }
    }
}
