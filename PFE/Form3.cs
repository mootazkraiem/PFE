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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'sAMUDataSet21.patientT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientTTableAdapter.Fill(this.sAMUDataSet21.patientT);

        }
    }
}
