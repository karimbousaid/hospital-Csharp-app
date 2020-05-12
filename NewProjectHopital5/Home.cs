using NewProjectHopital5.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProjectHopital5
{
    public partial class Home : Form
    {
        public Home()
        {
            Thread t = new Thread(new ThreadStart(Start));
            t.Start();
            Thread.Sleep(6000);
            InitializeComponent();
            t.Abort();          
        }

        private void gestionDesPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterPatient p = new AjouterPatient();
            p.ShowDialog();


        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercherPatient r = new RechercherPatient();
            r.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImpressionPatient p = new ImpressionPatient();
            p.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            gestionDesPatientToolStripMenuItem.Enabled = false;
            gestionDesMedecinsToolStripMenuItem.Enabled = false;
            gestionDeServicesToolStripMenuItem.Enabled = false;
            gestionDePassageDePatientToolStripMenuItem.Enabled = false;
            gestionDesRendezvousToolStripMenuItem.Enabled = false;
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjouterMedecins a = new AjouterMedecins();
            a.ShowDialog();
        }

        private void rechercherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RechercherMedecin r = new RechercherMedecin();
            r.ShowDialog();
        }

        private void consultéRDVParMedecinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RDVparMedecinForm r = new RDVparMedecinForm();
            r.ShowDialog();
        }

        private void gestionDesRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void associerUnRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void validerLeRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void validerLeRendezvousToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ValidationRDV v = new ValidationRDV();
            v.ShowDialog();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");
        SqlDataReader dr;
        int nbfois = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Usertxt.Text == "" || Passwtxt.Text == "" || Jobtxt.Text == "")
            {
                MessageBox.Show("champ ne doit pas étre vide","Information");
            }
            else
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from Utilisateur where Nom_user='" + Usertxt.Text + "' and ModePasse_user='" + Passwtxt.Text + "' and Emploi_user='" + Jobtxt.Text + "'", cn);
               
                dr = cmd.ExecuteReader();
                int count = 0;

                if (dr.Read())
                {
                    count++;
                }
                if (count == 1)
                {

                    gestionDesPatientToolStripMenuItem.Enabled = true;
                    gestionDesMedecinsToolStripMenuItem.Enabled = true;
                    gestionDeServicesToolStripMenuItem.Enabled = true;
                    gestionDePassageDePatientToolStripMenuItem.Enabled = true;
                    gestionDesRendezvousToolStripMenuItem.Enabled = true;
                    label3.Text = "Admin :" + dr[1].ToString();
                    cn.Close();
                    return;
                }
                if (count == 0)
                {
                    MessageBox.Show("authentification n'est pas correcte ");
                    nbfois += 1;
                }
                if (nbfois == 3)
                {
                    ModifierMtxt.Text = "Modifier le Mot de passe";
                }
                cn.Close();
                dr.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Usertxt.Clear();
            Passwtxt.Clear();
            Jobtxt.Text = null;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "Admin";
            gestionDesPatientToolStripMenuItem.Enabled = false;
            gestionDesMedecinsToolStripMenuItem.Enabled = false;
            gestionDeServicesToolStripMenuItem.Enabled = false;
            gestionDePassageDePatientToolStripMenuItem.Enabled = false;
            gestionDesRendezvousToolStripMenuItem.Enabled = false;
            Usertxt.Text = "UserName";
            Passwtxt.Text = "Mode Pass";
            Jobtxt.Text = null;
            ModifierMtxt.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Usertxt.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Passwtxt.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (Usertxt.Text == "")
            {
                Usertxt.Text = "UserName";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (Passwtxt.Text == "")
            {
                Passwtxt.Text = "Mode Pass";
            }
        }

        private void consulterLesRendezVousValideNoValideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CosulterRDVvalide c = new CosulterRDVvalide();
            c.ShowDialog();
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AjouterService a = new AjouterService();
            a.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerServicee s = new SupprimerServicee();
            s.ShowDialog();
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NIndisponibilitéMedcin n = new NIndisponibilitéMedcin();
            n.ShowDialog();
        }

        private void gestionDesMedecinsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void miseÀJourToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            UpdatePassword p = new UpdatePassword();
            p.ShowDialog();
        }
        public void Start()
        {
            Application.Run(new ScreenForm());
        }
    }
}

