using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace PFE
{
    public partial class appelparanne : Form
    {
        public appelparanne()
        {
            InitializeComponent();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            registerclassDataContext db = new registerclassDataContext();
            chartpie.DataSource = db.viewch1.ToList();
            chartpie.Series["sales"].XValueMember = "year";
            chartpie.Series["sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartpie.Series["sales"].YValueMembers = "numfiches";
            chartpie.Series["sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart.DataSource = db.viewch1.ToList();
            chart.Series["numero de fiches"].XValueMember = "year";
            chart.Series["numero de fiches"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart.Series["numero de fiches"].YValueMembers = "numfiches";
            chart.Series["numero de fiches"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        private void appelparanne_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stats s = new stats();
            s.ShowDialog();
            Hide();
        }
    }
}
