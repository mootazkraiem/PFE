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
    public partial class validationfinal : Form
    {
        public validationfinal()
        {
            InitializeComponent();
        }
        registerclassDataContext db = new registerclassDataContext();
        public int max()
        {
            var maxId = ((from tab1 in db.Appeltable select (int?)tab1.CleAppel).Max() ?? 0) ;

            return maxId + 1;
        }
        private void registerbtn_Click(object sender, EventArgs e)

        {
            //validation finale
            string mission = missionbox.Text;
            string utilitedintervention = utoiliteinterventionbox.Text;
            //typologie et codage
            string typologiepathologie = typologieetcodage.instance.typologiepathologiebox.Text;
            string pathologie = typologieetcodage.instance.pathologiebox.Text;
            //motif d'appel
            string motifapp = motifdappel.instance.motifdappelcombobox.Text;
            string objetdemande = motifdappel.instance.Objetdemandetxtbox.Text;
            //information patient 
            string idpatient = (informationdepatient.instance.idpatienttxtbox.Text);
            string nom = informationdepatient.instance.nomtxtbox.Text;
            string prenom = informationdepatient.instance.prenomtxtbox.Text;
            int age = int.Parse(informationdepatient.instance.agetxtbox.Text);
            string genre = informationdepatient.instance.genrecombobox.Text;
            string lieupatient = informationdepatient.instance.lieudepatienttxtbox.Text;
            string gouvernorat = informationdepatient.instance.gouvernorattxtbox.Text;
            int telephone = int.Parse(informationdepatient.instance.idpatienttxtbox.Text);
       
            //Horraire de la mission
            string code = detailsdefiche.instance.numfichetxtbox.Text.ToString();
            string Heuredepart = HorrairedelaMission.instance.heuredeparttmr.Text.ToString();
            string Heurearriveaulieu = HorrairedelaMission.instance.heurearriveaulieutmr.Text.ToString();
            string Heurebilan = HorrairedelaMission.instance.heurebilantmr.Text.ToString();
            string Heuredepartdestination = HorrairedelaMission.instance.heuredepartdestinationtmr.Text.ToString();
            string Heurearrivedestination = HorrairedelaMission.instance.heurearrivedestinationtmr.Text.ToString();
            string Heuredepartsec0 = HorrairedelaMission.instance.heuredepartsec0tmr.Text.ToString();
            string Heuredisp = HorrairedelaMission.instance.heuredisptmr.Text.ToString();
            string Heureretourbase = HorrairedelaMission.instance.heureretourbasetmr.Text.ToString();
            //fiche medical
           
            int idappelant = int.Parse(fichemedical.instance.idappelanttxtbox.Text);
            int cin = int.Parse(fichemedical.instance.cinappelanttxtbox.Text);
            string date = fichemedical.instance.daltetmr.Text;
            string time = fichemedical.instance.heuretmr.Text;
            string nomappelant = fichemedical.instance.nomappelantbox.Text;
            string telephoneappenlant = fichemedical.instance.telephonebox.Text;
            string gouvernerat = fichemedical.instance.gouvernorattxtbox.Text;
            string arrivedappel = fichemedical.instance.arrivedappelcombobox.Text;
            string appelant = fichemedical.instance.appelantcombobox.Text;
            string etatappel = fichemedical.instance.etatdappelcombobox.Text;
            //detailsfiche
            int numfiche = int.Parse(detailsdefiche.instance.numfichetxtbox.Text);
            string dateappel = detailsdefiche.instance.appeldatetxtbox.Text;
            string heureappel = detailsdefiche.instance.heuredappeltxtbox.Text;
            string medreg = detailsdefiche.instance.medecinregtxtbox.Text;
            int nbvic = int.Parse(detailsdefiche.instance.nbvictimestxtbox.Text);
            string param = detailsdefiche.instance.paramtxtbox.Text;
         
            //destination de patient

            string destinationdesire = Destinationpatient.instance.destinationdesireetxtbox.Text;
            string obtenue = Destinationpatient.instance.obtenuetxtbox.Text;
            string destinationfinale = Destinationpatient.instance.destinationfinaletxtbox.Text; 
            //donneés bilan d'equipe
            
            string bilan = Bilandequipe.instance.bilantxtbox.Text;
            string gcs = Bilandequipe.instance.gcstxtbox.Text;
            string ta = Bilandequipe.instance.tatxtbox.Text;
            string fr =Bilandequipe.instance.frtextbox.Text;
            string pouls = Bilandequipe.instance.poulstxtbox.Text;
            string spo2 = Bilandequipe.instance.spo2txtbox.Text ;
            string t = Bilandequipe.instance.Ttextbox.Text;
            string dextro =Bilandequipe.instance.dextrotextbox.Text;
           
            //donneés decision de regulation 
            string decisionderegulation = Decisionderegulation.instance.decisionderegulationcombobox.Text;
            string vehiculeengage = Decisionderegulation.instance.vehiculeengagecomboBox.Text;
            string medecins = Decisionderegulation.instance.medecinscomboBox.Text;
            //lieu de patient 

            string lieup = lieudepatient.instance.lieucombobox.Text;
            string autrelieu = Autrelieudepatient.instance.autrelieutxtbox.Text; 
            string hopital = Autrelieudepatient.instance.hopitaltxtbox.Text;
            string service = Autrelieudepatient.instance.servicetxtbox.Text;
            
           

            //SAUVGERDAGE DANS LA TABLE APPEL
            var cc = new Appeltable
            {
                CleAppel = max(),
                Medecinregulateur = medreg,
                arriveappel = arrivedappel,
                NBvictimes = nbvic,
                Param = param,
                date = date,
                destinationdesire=destinationdesire,
                Objetdedemande = objetdemande,
                Decisionderegulation = decisionderegulation,
                Vehiculeengage = vehiculeengage, 
                Motifdappel = motifapp,
                Typologiepathologie = typologiepathologie,
                pathologie = pathologie,
                Validationmission = mission,
                Utilitedemission = utilitedintervention,
                

        };
            db.Appeltable.InsertOnSubmit(cc);
            db.SubmitChanges();


            //SAUVGERDAGE DANS LA TABLE PATIENT

            var bb = new patientT
            {
                IDpatient = idpatient,
                Nompatient = nom,
                Prenompatient = prenom,
                Agepatient = age,
                Genrepatient = genre,
                Gouvernoratpatient = gouvernerat,
                Gcs = gcs,
                TA = ta,
                Pouls = pouls,
                FR = fr,
                SPO2 = spo2,
                T = t,
                Dextro = dextro,

            };
            db.patientT.InsertOnSubmit(bb);
            db.SubmitChanges();
            
            //SAUVGERDAGE DANS LA TABLE APPELANT
            
            var rr = new Appelant_table
            {
                ID_appelant = idappelant,
                Nom_appelant = nomappelant,
                appelant= appelant,
                Telephone_appelant = telephoneappenlant,
                CIN_appelant = cin,


            };
            db.Appelant_table.InsertOnSubmit(rr);
            db.SubmitChanges();
            
            //SAUVGERDAGE DANS LA TABLE horraire de mission
            
            var tt = new Horraire_de_la_mission
            {
                code = code ,
                Heuredepart = Heuredepart,
                Heurearriveaulieu = Heurearriveaulieu,
                Heurebilan = Heurebilan,
                Heuredepartdestination = Heuredepartdestination,
                Heurearrivedestination = Heurearrivedestination,
                Heuredepartsec0 = Heuredepartsec0,
                Heuredisp = Heuredisp,
                Heureretourbase = Heureretourbase,

            };
            db.Horraire_de_la_mission.InsertOnSubmit(tt);
            db.SubmitChanges();
            //SAUVGERDAGE DANS LA TABLE lieu de patient
            
            var nn = new Lieu_de_patient_table
            {   code = code ,
                Lieudepatient = lieupatient,
                Autrelieu = autrelieu,
                Hopital = hopital,
                service = service,


            };
            db.Lieu_de_patient_table.InsertOnSubmit(nn);
            db.SubmitChanges();
            /*SAUVGERDAGE DANS LA TABLE appel utilisateur
            string identif = login.instance.identifiant;
            var bv = new Appel_Utilisateur_table
            { clefiche = numfiche,
               identifiant = identif,


            };
            db.Appel_Utilisateur_table.InsertOnSubmit(bv);
            db.SubmitChanges();*/
            //SAUVGERDAGE DANS LA TABLE appel patient
            

            MessageBox.Show("Enregistrement validé !");
            acc f = new acc();
            f.Show();
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal Heuredepart = decimal.Parse(HorrairedelaMission.instance.heuredeparttmr.Text);
            decimal Heurearriveaulieu = decimal.Parse(HorrairedelaMission.instance.heurearriveaulieutmr.Text);
            decimal Heurebilan = decimal.Parse(HorrairedelaMission.instance.heurebilantmr.Text);
            string Heuredepartdestination = HorrairedelaMission.instance.heuredepartdestinationtmr.ToString();
            decimal Heurearrivedestination = decimal.Parse(HorrairedelaMission.instance.heurearrivedestinationtmr.Text);
            decimal Heuredepartsec0 = decimal.Parse(HorrairedelaMission.instance.heuredepartsec0tmr.Text);
            decimal Heuredisp = decimal.Parse(HorrairedelaMission.instance.heuredisptmr.Text);
            decimal Heureretourbase = decimal.Parse(HorrairedelaMission.instance.heureretourbasetmr.Text);
            HorrairedelaMission f = new HorrairedelaMission();
            f.heuredeparttmr.Text = Heuredepart.ToString(); 
            f.heurearriveaulieutmr.Text = Heurearriveaulieu.ToString();
            f.heurebilantmr.Text = Heurebilan.ToString();
            f.heuredepartdestinationtmr.Text = Heuredepartdestination.ToString();
            f.heurearrivedestinationtmr.Text = Heurearrivedestination.ToString();
            f.heuredepartsec0tmr.Text = Heuredepartsec0.ToString();
            f.heuredisptmr.Text = Heuredisp.ToString();
            f.heureretourbasetmr.Text = Heureretourbase.ToString();



            f.Show();
            Hide();
        }

        private void validationfinal_Load(object sender, EventArgs e)
        {



            
            

       
        }
    }
}