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
    public partial class acc : Form
    {
        public static acc instance;
        public acc()
        {
            InitializeComponent();
          instance=this;
        }
      
        registerclassDataContext db = new registerclassDataContext();
       
        public int max()
        {
            var maxId = (db.Appeltable.Select(x => (int?)x.CleAppel).Max() ?? 0) + 1;

            return (maxId + 1);

        }
        private void registerbtn_Click(object sender, EventArgs e)
        {
            
            
           
           
            fichemedical f = new fichemedical();
            f.idappelanttxtbox.Text = max().ToString();
            f.Show();
           
           
    
            Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           chercher ch = new chercher();
            ch.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modifsupprision m = new modifsupprision();
            m.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            statistiques s = new statistiques();
            s.Show();
            this.Close();
        }

        private void acc_Load(object sender, EventArgs e)
        {

        }
    }
}
