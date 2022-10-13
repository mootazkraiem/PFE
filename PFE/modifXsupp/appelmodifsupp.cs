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
    public partial class appelmodifsupp : Form
    {
        public appelmodifsupp()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        private void appelmodifsupp_Load(object sender, EventArgs e)
        {
            charge_load();
        }

        private void charge_load()
        {
            var appel = from a in db.Appeltable
                        select new
                        {
                            a.Medecinregulateur,
                            a.NBvictimes,
                            a.Param,
                            a.Decisionderegulation,
                            a.Vehiculeengage,
                            a.Motifdappel,
                            a.Typologiepathologie,
                            a.pathologie,
                            a.Validationmission,
                            a.Utilitedemission,
                            a.Objetdedemande,
                        };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (byidtxtbox.Text != "")
            {
                var Appel = db.Appeltable.SingleOrDefault(x => x.CleAppel == Convert.ToInt32(byidtxtbox.Text));
                if (Appel != null)
                {
                    medregtxt.Text = Appel.Medecinregulateur;
                    nbvictxt.Text = Appel.NBvictimes.ToString();
                    paramtxt.Text = Appel.Param;
                    decisiontxt.Text = Appel.Decisionderegulation;
                    vehiculetxt.Text = Appel.Vehiculeengage;
                    motiftxt.Text = Appel.Motifdappel;
                    typologietxt.Text = Appel.Typologiepathologie;
                    pathologietxt.Text = Appel.pathologie;
                    validationtxt.Text = Appel.Validationmission;
                    utilitetxt.Text = Appel.Utilitedemission;
                    Objetdemandetxtbox.Text = Appel.Objetdedemande;
                }
                else MessageBox.Show("cet ID n'existe pas");
            }
            else MessageBox.Show("saiser l'ID svp");
        }
        private void modifierbtn_click(object sender, EventArgs e)
        {
           


        }
        private void supprimerbtn_click(object sender, EventArgs e)
        {

        }

        private void modifierbtn_Click_1(object sender, EventArgs e)
        {
            var Appel = db.Appeltable.Single(x => x.CleAppel == Convert.ToInt32(byidtxtbox.Text));

            Appel.Medecinregulateur = medregtxt.Text;
            Appel.NBvictimes = int.Parse(nbvictxt.Text);
            Appel.Param = paramtxt.Text;
            Appel.Decisionderegulation = decisiontxt.Text;
            Appel.Vehiculeengage = vehiculetxt.Text;
            Appel.Motifdappel = motiftxt.Text;
            Appel.Typologiepathologie = typologietxt.Text;
            Appel.pathologie = pathologietxt.Text;
            Appel.Validationmission = validationtxt.Text;
            Appel.Utilitedemission = utilitetxt.Text;
            Appel.Objetdedemande = Objetdemandetxtbox.Text;
            db.SubmitChanges();
            charge_load();

        }

        private void Supprimerbtn_Click_1(object sender, EventArgs e)
        {
            var p = db.Appeltable.Single(x => x.CleAppel == Convert.ToInt32(byidtxtbox.Text));
            db.Appeltable.DeleteOnSubmit(p);
            db.SubmitChanges();
            charge_load();
        }
    }
}
