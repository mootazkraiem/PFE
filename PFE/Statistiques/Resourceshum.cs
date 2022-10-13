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
    public partial class Resourceshum : Form
    {
        public Resourceshum()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)

        {
         


            var medgen = db.registertbl.Count(zz => zz.role == "medecin generaliste");
            medecinsgeneralistestxtbox.Text = medgen.ToString();
            var sec = db.registertbl.Count(cc => cc.role == "secretaire");
            secretairestextbox.Text = sec.ToString();
            var permanencier = db.registertbl.Count(cc => cc.role == "permanencier");
            permanencierstextbox.Text = permanencier.ToString();
            var techsupp = db.registertbl.Count(cc => cc.role == "technecien superieur");
            techsupptextbox.Text = techsupp.ToString();
            var infirmier = db.registertbl.Count(cc => cc.role == "infirmier");
            infirmierstextbox.Text = infirmier.ToString();
            var ambulancier = db.registertbl.Count(cc => cc.role == "ambulancier");
            ambulancierstextbox.Text = ambulancier.ToString();
            var ouvrier = db.registertbl.Count(cc => cc.role == "ouvrier");
            ouvrierstextbox.Text = ouvrier.ToString();
            var pergardiennage = db.registertbl.Count(cc => cc.role == "personnel gardiennage");
            pergardiennagetextbox.Text = pergardiennage.ToString();
            var aidesoignante = db.registertbl.Count(cc => cc.role == "aide soignante");
            aidesoignantetextbox.Text = aidesoignante.ToString();

          

        }
}
    }