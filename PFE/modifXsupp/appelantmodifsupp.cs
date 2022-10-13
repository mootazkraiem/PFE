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
    public partial class appelantmodifsupp : Form
    {
        public appelantmodifsupp()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        private void button2_Click(object sender, EventArgs e)
        {
            if (byidtxtbox.Text != "")
            {
                var appelant = db.Appelant_table.SingleOrDefault(x => x.ID_appelant == Convert.ToInt32(byidtxtbox.Text));
                if (appelant != null)
                {
                    cinappelanttxtbox.Text = appelant.CIN_appelant.ToString();
                    nomappelantbox.Text = appelant.Nom_appelant;
                    telephonebox.Text = appelant.Telephone_appelant;
                    

                }
                else MessageBox.Show("cet ID n'existe pas");
            }
            else MessageBox.Show("saiser l'ID svp");
        }

        private void modifierbtn_Click(object sender, EventArgs e)
        {
            var appelant = db.Appelant_table.Single(x => x.ID_appelant == Convert.ToInt32(byidtxtbox.Text));

            appelant.CIN_appelant = int.Parse(cinappelanttxtbox.Text);
            appelant.Nom_appelant = nomappelantbox.Text;
            appelant.Telephone_appelant = telephonebox.Text;
            

            db.SubmitChanges();
            charge_load();
        }

        private void Supprimerbtn_Click(object sender, EventArgs e)
        {
            var appelant = db.Appelant_table.Single(x => x.ID_appelant == Convert.ToInt32(byidtxtbox.Text));
            db.Appelant_table.DeleteOnSubmit(appelant);
            db.SubmitChanges();
            charge_load();
        }
        private void charge_load()
        {
            var lieu = from a in db.Lieu_de_patient_table
                       select new
                       {
                           a.Lieudepatient,
                           a.Autrelieu,
                           a.Hopital,
                           a.service,

                       };
        }
        private void appelantmodifsupp_Load(object sender, EventArgs e)
        {
            charge_load();
        }

        private void byidtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cinappelanttxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void nomappelantbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephonebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    
}
