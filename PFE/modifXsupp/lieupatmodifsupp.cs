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
    public partial class lieupatmodifsupp : Form
    {
        public lieupatmodifsupp()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        private void button2_Click(object sender, EventArgs e)
        {
            if (byidtxtbox.Text != "")
            {
                var lieu = db.Lieu_de_patient_table.SingleOrDefault(x => x.code == (byidtxtbox.Text));
                if (lieu != null)
                {
                    lieucombobox.Text = lieu.Lieudepatient;
                    autrelieutxtbox.Text = lieu.Autrelieu;
                    hopitaltxtbox.Text = lieu.Hopital;
                    servicetxtbox.Text = lieu.service;

                }
                else MessageBox.Show("cet ID n'existe pas");
            }
            else MessageBox.Show("saiser l'ID svp");
        }

        private void modifierbtn_Click(object sender, EventArgs e)
        {

            var lieu = db.Lieu_de_patient_table.Single(x => x.code == (byidtxtbox.Text));

            lieu.Lieudepatient = lieucombobox.Text;
            lieu.Autrelieu = autrelieutxtbox.Text;
            lieu.Hopital = hopitaltxtbox.Text;
            lieu.service = servicetxtbox.Text;

            db.SubmitChanges();
            charge_load();
        }

        private void Supprimerbtn_Click(object sender, EventArgs e)
        {
            var p = db.Horraire_de_la_mission.Single(x => x.code == (byidtxtbox.Text));
            db.Horraire_de_la_mission.DeleteOnSubmit(p);
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
        private void lieupatmodifsupp_Load(object sender, EventArgs e)
        {
            charge_load();
        }

    }
}
