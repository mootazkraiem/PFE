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
    public partial class fiches_par_medreg : Form
    {
        public fiches_par_medreg()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registerclassDataContext db = new registerclassDataContext();
            chartpie.DataSource = db.fichesparmedreg.ToList();
            chartpie.Series["fiches"].XValueMember = "medreg";
            chartpie.Series["fiches"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartpie.Series["fiches"].YValueMembers = "cle";
            chartpie.Series["fiches"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        private void chartpie_Click(object sender, EventArgs e)
        {

        }
    }
}
