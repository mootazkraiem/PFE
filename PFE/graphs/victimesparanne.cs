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
    public partial class victimesparanne : Form
    {
        public victimesparanne()
        {
            InitializeComponent();
        }

        private void victimesparanne_Load(object sender, EventArgs e)
        {

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void btnfds_Click(object sender, EventArgs e)
        {

            registerclassDataContext db = new registerclassDataContext();

            chart.DataSource = db.vicparanne.ToList();

            chart.Series["age"].XValueMember = "age";
            chart.Series["age"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart.Series["age"].YValueMembers = "nbvic";
            chart.Series["age"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
