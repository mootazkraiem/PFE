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
    public partial class espace_admin : Form
    {
        public espace_admin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void espace_admin_Load(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_config a = new User_config();
            a.Show();
            Hide();
        }
    }
}
