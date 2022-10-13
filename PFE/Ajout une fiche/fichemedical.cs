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
    public partial class fichemedical : Form
    {
        public static fichemedical instance;
        public fichemedical()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            acc a = new acc();
            a.ShowDialog();
            this.Hide();
        }
      
        private void datelabel_Click(object sender, EventArgs e)
        {
    
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fichemedical_Load(object sender, EventArgs e)
        {
            
        }

        registerclassDataContext db = new registerclassDataContext();
        public int max()
        {
            var maxId = (db.Appeltable.Select(x => (int?)x.CleAppel).Max() ?? 0) + 1;

            return (maxId + 1);

        }
        public void registerbtn_Click(object sender, EventArgs e)
        {
            if (telephonebox.Text.Length != 8)
            {
                MessageBox.Show("Numero de telephone invalide !");
            }
            if (cinappelanttxtbox.Text.Length != 8)
            {
                MessageBox.Show("Cin invalide !");
            }
            if ((string.IsNullOrEmpty(cinappelanttxtbox.Text)) || (string.IsNullOrEmpty(telephonebox.Text) || (string.IsNullOrEmpty(nomappelantbox.Text) || (string.IsNullOrEmpty(appelantcombobox.Text)) )))
                {

                MessageBox.Show("Remplir les champs obligatoires");
            }
            else {
                detailsdefiche f = new detailsdefiche();

                f.numfichetxtbox.Text = max().ToString();
                f.Show();
                this.Hide();
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acc a = new acc();
            a.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cinappelanttxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if ((sender as TextBox).Text.Count(char.IsDigit) >= 8){
                    e.Handled = true;
                }
            }
        }

        private void telephonebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nomappelantbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if ((sender as TextBox).Text.Count(char.IsDigit) >= 8){
                    e.Handled = true;
                }
            }
        }

        private void telephonebox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
