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
    public partial class Horrairemissmodifsupp : Form
    {
        public Horrairemissmodifsupp()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        private void charge_load()
        {
            var horr = from a in db.Horraire_de_la_mission
                        select new
                        {
                            a.Heurearriveaulieu,
                            a.Heurearrivedestination,
                            a.Heurebilan,
                            a.Heuredepart,
                            a.Heuredepartsec0,
                            a.Heuredepartdestination,
                            a.Heuredisp,
                            a.Heureretourbase,


                        };
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (byidtxtbox.Text != "")
            {
                var hrr = db.Horraire_de_la_mission.SingleOrDefault(x => x.code == (byidtxtbox.Text));
                if (hrr != null)
                {
                    heurearriveaulieutmr.Text = hrr.Heurearriveaulieu;
                    heurearrivedestinationtmr.Text = hrr.Heurearrivedestination;
                    heurebilantmr.Text = hrr.Heurebilan;
                    heuredeparttmr.Text = hrr.Heuredepart;
                    heuredepartsec0tmr.Text = hrr.Heuredepartsec0;
                    heuredepartdestinationtmr.Text = hrr.Heuredepartdestination;
                    heuredisptmr.Text = hrr.Heuredisp;
                    heureretourbasetmr.Text = hrr.Heureretourbase;
                   
                }
                else MessageBox.Show("cet ID n'existe pas");
            }
            else MessageBox.Show("saiser l'ID svp");
        }

        private void modifierbtn_Click(object sender, EventArgs e)
        {
            var hrr = db.Horraire_de_la_mission.Single(x => x.code == (byidtxtbox.Text));

            hrr.Heurearriveaulieu = heurearriveaulieutmr.Text;
            hrr.Heurearrivedestination = (heurearrivedestinationtmr.Text);
            hrr.Heurebilan = heurebilantmr.Text;
            hrr.Heuredepart = heuredeparttmr.Text;
            hrr.Heuredepartsec0 = heuredepartsec0tmr.Text;
            hrr.Heuredepartdestination = heuredepartdestinationtmr.Text;
            hrr.Heuredisp = heuredisptmr.Text;
            hrr.Heureretourbase = heureretourbasetmr.Text;
         
            db.SubmitChanges();
            charge_load();
        }

        private void Supprimerbtn_Click(object sender, EventArgs e)
        {
            var p = db.Horraire_de_la_mission.Single(x => x.code == (byidtxtbox.Text));
            db.Horraire_de_la_mission.DeleteOnSubmit(p);
            db.SubmitChanges();
            charge_load();
        }

        private void Horrairemissmodifsupp_Load(object sender, EventArgs e)
        {
            charge_load();
        }
    }
}
