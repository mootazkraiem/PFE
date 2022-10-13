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
    public partial class Decision : Form
    {
        public Decision()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        private void button2_Click(object sender, EventArgs e)
        {

            var Conseil = db.Appeltable.Count(zz => zz.Decisionderegulation == "Conseil");
            conceiltxt.Text = Conseil.ToString();
            var refus = db.Appeltable.Count(cc => cc.Validationmission == "Refuse Transport ou examen");
            refustxt.Text = refus.ToString();
            var annule = db.Appeltable.Count(cc => cc.Decisionderegulation == "Annulé Av.Dép");
            annuletxt.Text = annule.ToString();
            var demandeincomplete = db.Appeltable.Count(cc => cc.Decisionderegulation == "Demande incompléte");
            demandeincompletetxt.Text = demandeincomplete.ToString();
            var maladenontrouve = db.Appeltable.Count(cc => cc.Validationmission == "Non trouvé");
            maladenontrouvetxt.Text = maladenontrouve.ToString();
            var ambulanceB = db.Appeltable.Count(cc => cc.Vehiculeengage == "Catégorie B");
            interventionambulancetxt.Text = ambulanceB.ToString();
        }
    }
}
