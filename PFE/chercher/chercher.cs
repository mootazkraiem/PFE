using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PFE
{
    public partial class chercher : Form
    {
        public chercher()
        {
            InitializeComponent();
           
        }
        string connectionString = @"Data Source=DESKTOP-R87NU04\DESK1;Initial Catalog=SAMU;Integrated Security=True";
        registerclassDataContext db = new registerclassDataContext();
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chercher_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'sAMUDataSet7.AppelPatientTable'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.appelPatientTableTableAdapter.Fill(this.sAMUDataSet7.AppelPatientTable);



        }
        public int count = 0;
       
        

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
        

        private void label2_Click(object sender, EventArgs e)
        {

        }


        

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void advancedDataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            loadform(new appelchercher());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new patientchercher());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new horrairedemissionchercher());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Lieudepatientchercher());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new appelantrecherche());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            acc f = new acc();
            f.Show();
           
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    
