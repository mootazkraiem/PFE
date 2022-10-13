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
    public partial class intervention : Form
    {
        public intervention()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();   

        private void button2_Click(object sender, EventArgs e)
        {
            
            var pathologie = db.Appeltable.Count(zz => zz.pathologie == "Neurologique");
            patienttxt.Text = pathologie.ToString();
            var uro = db.Appeltable.Count(cc => cc.pathologie == "Uro/Nephro");
            UroNephrotxt.Text = uro.ToString();
            var Infectieuse = db.Appeltable.Count(cc => cc.pathologie == "Infectieuse");
            Infectieusetxt.Text = Infectieuse.ToString();
            var Toxico = db.Appeltable.Count(cc => cc.pathologie == "Clinique privée");
            Toxicotxt.Text = Toxico.ToString();
            var opth = db.Appeltable.Count(cc => cc.pathologie == "Opht/ORL/Max Fac");
            Ophttxt.Text = opth.ToString();
            var Psychiatrique = db.Appeltable.Count(cc => cc.pathologie == "Psychiatrique");
            Psychiatriquetxt.Text = Psychiatrique.ToString();




        }
    }
}
