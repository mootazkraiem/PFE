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
    public partial class fiches_par_appelant : Form
    {
        public fiches_par_appelant()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registerclassDataContext db = new registerclassDataContext();
            chartpie.DataSource = db.ficheparmotifcreate.ToList();
            chartpie.Series["fiches"].XValueMember = "motif";
            chartpie.Series["fiches"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartpie.Series["fiches"].YValueMembers = "cle";
            chartpie.Series["fiches"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }
    }
}
