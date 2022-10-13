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
    public partial class horrairedemissionchercher : Form
    {
        public horrairedemissionchercher()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void horrairedemissionchercher_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'sAMUDataSet16.Horraire_de_la_mission'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.horraire_de_la_missionTableAdapter1.Fill(this.sAMUDataSet16.Horraire_de_la_mission);


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void advancedDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
