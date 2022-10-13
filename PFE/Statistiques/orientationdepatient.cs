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
    public partial class orientationdepatient : Form
    {
        public orientationdepatient()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        private void button2_Click(object sender, EventArgs e)
        {
            var pathologie = db.Appeltable.Count(zz => zz.destinationdesire == "Urgences");
            urgencetxt.Text = pathologie.ToString();
            var spesialiser = db.Appeltable.Count(cc => cc.Decisionderegulation == "Vers Urg.par Moy.Simple");
            spesialisertxt.Text = spesialiser.ToString();
            var dcd = db.Appeltable.Count(cc => cc.Validationmission == "DCD");
            dcdtxt.Text = dcd.ToString();
            var refus = db.Appeltable.Count(cc => cc.Validationmission == "Refuse Transport ou examen");
            refusetxt.Text = refus.ToString();

        }
    }
}
