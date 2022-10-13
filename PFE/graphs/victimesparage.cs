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
    public partial class victimesparage : Form
    {
        public victimesparage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registerclassDataContext db = new registerclassDataContext();
           
                     chart.DataSource = db.vicparage.ToList();
                   
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
