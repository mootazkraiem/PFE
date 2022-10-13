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
    public partial class login : Form
    {
        public static login instance;
        public login()
        {
            InitializeComponent();
            instance = this ; 
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            passwordbox.UseSystemPasswordChar = false;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            passwordbox.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
           
        }
        private bool Isvalid(string user, string pwd)

        {



            registerclassDataContext db = new registerclassDataContext();

            var st = from s in db.registertbl

                     where s.identifiant == textBox1.Text

                     && s.motdepasse == passwordbox.Text

                     select s;


            
            var serv = db.registertbl.Select(zz => zz.service == "urgence");
            if (st.Any())

            {
                
                return true;
            }
            else
            {
               
                return false;

            }

        }
        private bool valid(string user, string pwd)

        {



            registerclassDataContext db = new registerclassDataContext();

            var st = from s in db.registertbl

                     where s.identifiant == textBox1.Text

                     && s.motdepasse == passwordbox.Text
                     && s.role =="administrateur"

                     select s;



            if (st.Any())

            {

                return true;
            }
            else
            {

                return false;

            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (valid(textBox1.Text, passwordbox.Text))
            {
                espace_admin a = new espace_admin();
                Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("Vérifier si vous disposez des droits d'administrateur");
            }


           
        
    }
         public string identifiant;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            
            if (Isvalid(textBox1.Text, passwordbox.Text)&& serv)
            {
                 identifiant = textBox1.Text;
                acc a = new acc();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("verifier vos infos");
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
  
}
