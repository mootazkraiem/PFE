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
    public partial class appelantrecherche : Form
    {
        public appelantrecherche()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        private void appelantrecherche_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'sAMUDataSet14.Appelant_table'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.appelant_tableTableAdapter1.Fill(this.sAMUDataSet14.Appelant_table);
            // TODO: cette ligne de code charge les données dans la table 'sAMUDataSet13.Appelant_table'. Vous pouvez la déplacer ou la supprimer selon les besoins.

        }

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
