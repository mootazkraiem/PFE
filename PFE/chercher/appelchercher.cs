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
    public partial class appelchercher : Form
    {
        public appelchercher()
        {
            InitializeComponent();
        }

        private void appelchercher_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'sAMUDataSet15.Appeltable'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.appeltableTableAdapter1.Fill(this.sAMUDataSet15.Appeltable);


        }
        registerclassDataContext db = new registerclassDataContext();
        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void advancedDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
