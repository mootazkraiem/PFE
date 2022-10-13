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
    public partial class Ageparanne : Form
    {
        public Ageparanne()
        {
            InitializeComponent();
        }

        private void Ageparanne_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registerclassDataContext db = new registerclassDataContext();
            
            chart.DataSource = db.ageparanne.ToList();
            chart.Series["numero de fiches"].XValueMember = "age";
            chart.Series["numero de fiches"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart.Series["numero de fiches"].YValueMembers = "year";
            chart.Series["numero de fiches"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            }

        private void button2_Click(object sender, EventArgs e)
        {
            stats s = new stats();
            s.ShowDialog();
            Hide();
        }
    }
}
