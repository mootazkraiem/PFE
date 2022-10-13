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
    public partial class stats : Form
    {
        public stats()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new appelparanne());
            button2.Hide();
            button3.Hide();
            button4.Hide();
            ageparannebtn.Hide();
            fichesparmedregbtn.Hide();
            ficheparappelbtn.Hide();
            ficheparappelbtn.Hide();
            button1.Hide();
            fichesparparam.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox8.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox5.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new victimesparage());
            button2.Hide();
            button3.Hide();
            button4.Hide();
            ageparannebtn.Hide();
            ficheparappelbtn.Hide();
            ficheparappelbtn.Hide();
            fichesparmedregbtn.Hide();
            button1.Hide();
            fichesparparam.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox8.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox5.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new victimesparanne());
            button2.Hide();
            button3.Hide();
            button4.Hide();
            ageparannebtn.Hide();
            ficheparappelbtn.Hide();
            ficheparappelbtn.Hide();
            fichesparmedregbtn.Hide();
            button1.Hide();
            fichesparparam.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox8.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox5.Hide();



        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Ageparanne());
            button2.Hide();
            button3.Hide();
            button4.Hide();
            ageparannebtn.Hide();
            ficheparappelbtn.Hide();
            ficheparappelbtn.Hide();
            fichesparmedregbtn.Hide();
            button1.Hide();
            fichesparparam.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox8.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox5.Hide();
        }

        private void stats_Load(object sender, EventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);

            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ficheparappelbtn_Click(object sender, EventArgs e)
        {
            loadform(new fiches_par_appelant());
            button2.Hide();
            button3.Hide();
            button4.Hide();
            ageparannebtn.Hide();
            ficheparappelbtn.Hide();
            ficheparappelbtn.Hide();
            fichesparmedregbtn.Hide();
            button1.Hide();
            fichesparparam.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox8.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox5.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadform(new fiches_par_arrive_dappel());
            button2.Hide();
            button3.Hide();
            button4.Hide();
            ageparannebtn.Hide();
            ficheparappelbtn.Hide();
            ficheparappelbtn.Hide();
            fichesparmedregbtn.Hide();
            button1.Hide();
            fichesparparam.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox8.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox5.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void ageparannebtn_Click(object sender, EventArgs e)
        {
            loadform(new Ageparanne());
            button2.Hide();
            button3.Hide();
            button4.Hide();
            ageparannebtn.Hide();
            ficheparappelbtn.Hide();
            ficheparappelbtn.Hide();
            fichesparmedregbtn.Hide();
            button1.Hide();
            fichesparparam.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox8.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox5.Hide();
        }

        private void fichesparmedregbtn_Click(object sender, EventArgs e)
        {
            loadform(new fiches_par_medreg());
            button2.Hide();
            button3.Hide();
            button4.Hide();
            ageparannebtn.Hide();
            ficheparappelbtn.Hide();
            ficheparappelbtn.Hide();
            fichesparmedregbtn.Hide();
            button1.Hide();
            fichesparparam.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox8.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox5.Hide();
        }

        private void fichesparparam_Click(object sender, EventArgs e)
        {
            loadform(new fichespar_pamanencier());
            button2.Hide();
            button3.Hide();
            button4.Hide();
            ageparannebtn.Hide();
            ficheparappelbtn.Hide();
            ficheparappelbtn.Hide();
            fichesparmedregbtn.Hide();
            button1.Hide();
            fichesparparam.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox8.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox5.Hide();
        }
    }
}
