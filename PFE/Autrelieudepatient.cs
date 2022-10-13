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
    public partial class Autrelieudepatient : Form
    {
        public static Autrelieudepatient instance;
        public Autrelieudepatient()
        {
            InitializeComponent();
            instance = this ; 
        }

        private void Autrelieudepatient_Load(object sender, EventArgs e)
        {

        }
    }
}
