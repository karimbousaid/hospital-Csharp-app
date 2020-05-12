using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProjectHopital5
{
    public partial class GestionRDV : Form
    {
        public GestionRDV()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");
        SqlDataReader dr;
        SqlDataReader dr2;
        SqlTransaction tr;

        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        private string sexe;

        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            tr = cn.BeginTransaction();
            try
            {

            string p = "No Valide";        
            SqlCommand cmd3 = new SqlCommand("Ajouter", cn,tr);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@NumRdv",NumeroRDVtxt.Text);
            cmd3.Parameters.AddWithValue("@CodeM",CodeMtxt.Text);
            cmd3.Parameters.AddWithValue("@CodeP", CodePatienttxt.Text);
            cmd3.Parameters.AddWithValue("@DateRDV", DateRDVtxt.Value);
            cmd3.Parameters.AddWithValue("@HeureRDV", HeureRDVtxt.Text);
            cmd3.ExecuteNonQuery();         
            SqlCommand cmd5 = new SqlCommand("insert into EtatDePassment values('"+CodePatienttxt.Text+"','"+p+"',"+NumeroRDVtxt.Text+")",cn,tr);
            cmd5.ExecuteNonQuery();
            tr.Commit();
            button2.Enabled = false;
            DialogResult d = MessageBox.Show("le Patient prendre le Rendez-Vous le '" + DateRDVtxt.Text + "' à '" + HeureRDVtxt.Text + "' Click Ok Et attende l'impression de la Fiche de Rendez-Vous", "Suivant", MessageBoxButtons.OK);
                if(d==DialogResult.OK)
                {
                    button3.Visible = true;
                    ImprimerRDVForm i = new ImprimerRDVForm();
                    i.NumRDV = int.Parse(NumeroRDVtxt.Text);
                    i.Pass2(i.NumRDV);                
                    i.ShowDialog();                  
                }
             
            }
            catch
            {
                tr.Rollback();
                MessageBox.Show("Vérifier les informations de Rendez-vous ");
            }
            cn.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }
        SqlDataReader r;
        private void GestionRDV_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            cn.Open();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            NomPtextBox.Enabled = false;
            PrénomPatient.Enabled = false;
            Pass(Code,Nom,Prenom,Sexe);
            SqlCommand cmd7 = new SqlCommand("select [TypeService] from [servicee]", cn);
            r = cmd7.ExecuteReader();
            while(r.Read())
            {
                Spécialitétxt.Items.Add(r[0]);
            }
            cn.Close();
            r.Close();
        }

        private void CodeMcomboBox_Click(object sender, EventArgs e)
        {


        }
        string sexeP;
        private void button3_Click(object sender, EventArgs e)
        {
           
          

        }

        private void CodePatienttxt_Leave(object sender, EventArgs e)
        {
          
          
        }

        private void CodeMcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CodeMcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd2 = new SqlCommand("select CodeMedecin from Medecin where [NomMedecin]='" + NomMtxt.SelectedItem + "'", cn);
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                CodeMtxt.Text = dr2[0].ToString();
            }
            dr2.Close();
            cn.Close();
        }
        public void Pass(string n1, string n2, string n3, string n4)
        {
            CodePatienttxt.Text = n1;
            CodePatienttxt.Text = n1;
            NomPtextBox.Text = n2;
            PrénomPatient.Text = n3;
            if(n4=="H")
            {
                radioButton1.Checked = true;
            }
            else if (n4 == "F")
            {
                radioButton2.Checked = true;
            }
      
         }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NomMtxt.Items.Clear();
            cn.Open();
            SqlCommand cmd = new SqlCommand("select [CodeMedecin],[NomMedecin],[PrenomMedecin] from Medecin where [IdService] in (select [IdService]from [servicee] where [TypeService]='" + Spécialitétxt.SelectedItem + "')", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NomMtxt.Items.Add(dr[1]);             
            }
            dr.Close();
           
            cn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("delete from Patient where [CodePatient]='" + CodePatienttxt.Text + "'", cn);
            cm.ExecuteNonQuery();
            cn.Close();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
        //}

    }
}

