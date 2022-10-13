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
    public partial class Provenance_des_appels : Form
    {
        public Provenance_des_appels()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        private void Provenance_des_appels_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var pat = db.patientT.Count(zz => zz.IDpatient != string.Empty);
            patienttxt.Text = pat.ToString();
            var victime = db.Appeltable.Count(cc => cc.NBvictimes !=0);
            victimetxt.Text = victime.ToString();
            var temoin = db.Appeltable.Count(cc => cc.arriveappel == "Deplacement témoin");
            temointxt.Text = temoin.ToString();
            var clinique = db.Appelant_table.Count(cc => cc.appelant == "Clinique privée");
            cliniqueprvtxt.Text = clinique.ToString();
            var perciv = db.Appelant_table.Count(cc => cc.appelant == "P.civile");
            Ophttxt.Text = perciv.ToString();
            var ambulancier = db.Appelant_table.Count(cc => cc.appelant == "Autre");
            autrepersonnelsantetxt.Text = ambulancier.ToString();
        }
    }
}
