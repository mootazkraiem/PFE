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
    public partial class modifsupprision : Form
    {
        public static modifsupprision instance;
        public modifsupprision()
        {
            InitializeComponent();
            instance = this ;
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);

            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }
        private void modifsupprision_Load(object sender, EventArgs e)
        {

        }

        private void appelbtn_Click(object sender, EventArgs e)
        {
            loadform(new appelmodifsupp());
        }

        private void patientbtn_Click(object sender, EventArgs e)
        {
            loadform(new patirntsuppmodif());
        }

        private void hmbtn_Click(object sender, EventArgs e)
        {
            loadform(new Horrairemissmodifsupp());
        }

        private void lieudepbtn_Click(object sender, EventArgs e)
        {
            loadform(new lieupatmodifsupp());
        }

        private void appelantbtn_Click(object sender, EventArgs e)
        {
            loadform(new appelantmodifsupp());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            acc a = new acc();
            a.Show();
            Hide();
        }
    }
}
