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
    public partial class Lieudepatientchercher : Form
    {
        public Lieudepatientchercher()
        {
            InitializeComponent();
        }

        private void Lieudepatientchercher_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'sAMUDataSet17.Lieu_de_patient_table'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.lieu_de_patient_tableTableAdapter1.Fill(this.sAMUDataSet17.Lieu_de_patient_table);

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
