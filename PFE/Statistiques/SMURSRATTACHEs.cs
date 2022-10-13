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
    public partial class SMURSRATTACHEs : Form
    {
        public SMURSRATTACHEs()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
        registerclassDataContext db = new registerclassDataContext();
        private void button2_Click(object sender, EventArgs e)
        {

            var medgen = db.patientT.Count(zz => zz.Gouvernoratpatient == "gabes");
            smurgabestxt.Text = medgen.ToString();
            var sec = db.patientT.Count(cc => cc.Gouvernoratpatient == ("kebili"));
            kbelitxt.Text = sec.ToString();
            var permanencier = db.patientT.Count(cc => cc.Gouvernoratpatient == " tataouine");
            tataouinetxt.Text = permanencier.ToString();
            var techsupp = db.patientT.Count(cc => cc.Gouvernoratpatient == "medenine");
            medeninetxt.Text = techsupp.ToString();
        }

        private void SMURSRATTACHEs_Load(object sender, EventArgs e)
        {

        }
    }
}
