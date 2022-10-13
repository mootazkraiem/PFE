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
    public partial class fiches_par_arrive_dappel : Form
    {
        public fiches_par_arrive_dappel()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registerclassDataContext db = new registerclassDataContext();
            chartpie.DataSource = db.fichesparappel.ToList();
            chartpie.Series["fiches"].XValueMember = "arriveappel";
            chartpie.Series["fiches"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartpie.Series["fiches"].YValueMembers = "cle";
            chartpie.Series["fiches"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }
    }
}
