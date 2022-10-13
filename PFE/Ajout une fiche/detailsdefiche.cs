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
    public partial class detailsdefiche : Form
    {
        public static detailsdefiche instance;

        public detailsdefiche()
        {





            InitializeComponent();
            instance = this;


        }

        private void label5_Click(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private bool Isvalid()

        {



            if (string.IsNullOrEmpty(nbvictimestxtbox.Text) )

            {

                return true;
            }
            else
            {

                return false;

            }

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                MessageBox.Show("Nombre de victimes obligatoire !");

            }
            else
            {
              
                informationdepatient i = new informationdepatient();
                i.idpatienttxtbox.Text = max().ToString();
                i.Show();
                this.Hide();
            }


            

        }
    


        private void closebtn_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }

        private void detailsdefiche_Load(object sender, EventArgs e)
        {

        }

        private void nbvictimestxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            string date = fichemedical.instance.daltetmr.Text;
            string time = fichemedical.instance.heuretmr.Text;
            string nomappelant = fichemedical.instance.nomappelantbox.Text;
            string numtelephone = fichemedical.instance.telephonebox.Text;
            string gouvernerat = fichemedical.instance.gouvernorattxtbox.Text;
            string arrivedappel = fichemedical.instance.arrivedappelcombobox.Text;
            string appelant = fichemedical.instance.appelantcombobox.Text;
            string etatappel = fichemedical.instance.etatdappelcombobox.Text;
            string idappelant = fichemedical.instance.idappelanttxtbox.Text;
            string cinappelant = fichemedical.instance.cinappelanttxtbox.Text;
            this.Close();
            fichemedical a = new fichemedical();


            a.idappelanttxtbox.Text = idappelant;
            a.cinappelanttxtbox.Text = cinappelant;
            a.daltetmr.Text= date ;
            a.heuretmr.Text = time;
            a.nomappelantbox.Text = nomappelant;
            a.telephonebox.Text = numtelephone;
            a.gouvernorattxtbox.Text = gouvernerat;
            a.arrivedappelcombobox.Text = arrivedappel;
            a.appelantcombobox.Text = appelant;
            a.etatdappelcombobox.Text = etatappel;
            
            
            a.Show();

            

        }
        registerclassDataContext db = new registerclassDataContext();
        public int max()
        {
            var maxId = (db.Appeltable.Select(x => (int?)x.CleAppel).Max() ?? 0) + 1;

            return maxId + 1;
        }
     
        public void add()
        {
           
            
        }
        private void numfichetxtbox_TextChanged(object sender, EventArgs e)
        {
            numfichetxtbox.Text = max().ToString();
            numfichetxtbox.Show();
        }

        private void nbvictimestxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if ((sender as TextBox).Text.Count(char.IsDigit) >= 2)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
