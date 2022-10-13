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
    public partial class patirntsuppmodif : Form
    {
        public patirntsuppmodif()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        private void button2_Click(object sender, EventArgs e)
        {
            if (byidtxtbox.Text != "")
            {
                var patient = db.patientT.SingleOrDefault(x => x.IDpatient == (byidtxtbox.Text));
                if (patient != null)
                {
                    nomtxtbox.Text = patient.Nompatient;
                    prenomtxtbox.Text = patient.Prenompatient;
                    agetxtbox.Text = patient.Agepatient.ToString(); 
                    genrecombobox.Text = patient.Genrepatient;
                    gouvernorattxtbox.Text = patient.Gouvernoratpatient;
                    gcstxtbox.Text = patient.Gcs;
                    poulstxtbox.Text = patient.Pouls;
                    Ttextbox.Text = patient.T;
                    dextrotextbox.Text = patient.Dextro;
                    spo2txtbox.Text = patient.SPO2;
                    tatxtbox.Text = patient.TA;
                    frtextbox.Text = patient.FR;
                }
                else MessageBox.Show("cet ID n'existe pas");
            }
            else MessageBox.Show("saiser l'ID svp");
        }

        private void modifierbtn_Click(object sender, EventArgs e)
        {
            var patient = db.patientT.Single(x => x.IDpatient == (byidtxtbox.Text));

            patient.Nompatient = nomtxtbox.Text;
            patient.Prenompatient = prenomtxtbox.Text;
            patient.Agepatient = int.Parse(agetxtbox.Text);
            patient.Genrepatient = genrecombobox.Text;
            patient.Gouvernoratpatient = gouvernorattxtbox.Text ;
            patient.Gcs = gcstxtbox.Text;
            patient.Pouls = poulstxtbox.Text;
            patient.T = Ttextbox.Text;
            patient.Dextro = dextrotextbox.Text;
            patient.SPO2 = spo2txtbox.Text;
            patient.TA = tatxtbox.Text;
            patient.FR = frtextbox.Text;
            db.SubmitChanges();
            charge_load();
        }

        private void Supprimerbtn_Click(object sender, EventArgs e)
        {
            var p = db.patientT.Single(x => x.IDpatient ==(byidtxtbox.Text));
            db.patientT.DeleteOnSubmit(p);
            db.SubmitChanges();
            charge_load();
        }
        private void charge_load()
        {
            var appel = from a in db.Appeltable
                        select new
                        {
                            a.Medecinregulateur,
                            a.NBvictimes,
                            a.Param,
                            a.Decisionderegulation,
                            a.Vehiculeengage,
                            a.Motifdappel,
                            a.Typologiepathologie,
                            a.pathologie,
                            a.Validationmission,
                            a.Utilitedemission,
                            a.Objetdedemande,
                        };
        }
        private void patirntsuppmodif_Load(object sender, EventArgs e)
        {
            charge_load();
        }
    }
    }

