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
    public partial class fichespar_pamanencier : Form
    {
        public fichespar_pamanencier()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registerclassDataContext db = new registerclassDataContext();
            chartpie.DataSource = db.fichesparparam.ToList();
            chartpie.Series["fiches"].XValueMember = "param";
            chartpie.Series["fiches"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartpie.Series["fiches"].YValueMembers = "cle";
            chartpie.Series["fiches"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }
    }
}
